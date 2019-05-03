using System;
using System.IO;
using AspNetCoreDemos.DemoShell;
using AspNetCoreDemos.Reporting.Services;
using AspNetCoreDemos.Reporting.Vehicle;
using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpress.XtraReports.Web.ClientControls;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;

namespace AspNetCoreDemos.Reporting {
    public class Startup {
        public Startup(IConfiguration configuration, IHostingEnvironment env) {
            Configuration = configuration;
            HostingEnvironment = env;
        }

        public static IConfiguration Configuration { get; set; }
        public IHostingEnvironment HostingEnvironment { get; set; }
        public void ConfigureServices(IServiceCollection services) {
            services.AddDevExpressControls();
            var reportsCacheCleanerSettings = new CacheCleanerSettings(TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(1));
            services
                .AddSingleton<ICachedReportSourceWebResolver, DemoCachedReportSourceWebResolver>()
                .AddSingleton<IDemoReportSource, DemoReportSource>()
                .AddSingleton<CacheCleanerSettings>(reportsCacheCleanerSettings)
                .AddSingleton<ReportStorageWebExtension, DemoReportStorageWebExtension>();
            services.AddSession();
            services
                .AddMvc()
                .AddDefaultReportingControllers()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            services.AddDbContext<VehicleDataContext>(options => {
                options.UseSqlite(Configuration.GetConnectionString("VehiclesConnection"));
            });
            services.ConfigureReportingServices(configurator => {
                configurator.ConfigureWebDocumentViewer(viewerConfigurator => {
                    viewerConfigurator.UseFileDocumentStorage(Path.Combine(HostingEnvironment.ContentRootPath, "PreviewedReports"));
                });
            });

#if DEBUG
            services.AddScoped<DemoMenuMeta>();
#else
            services.AddSingleton<DemoMenuMeta>();
#endif
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerfactory) {
            if(env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseDevExpressControls();
            var reportingLogger = loggerfactory.CreateLogger("Reporting");
            Action<Exception, string> logError = (ex, message) => {
                var errorString = string.Format("[{0}]: Exception occurred. Message: '{1}'. Exception Details:\r\n{2}", DateTime.Now, message, ex);
                reportingLogger.LogError(errorString);
            };
            LoggerService.Initialize(logError);
            ReportStorageWebExtension.RegisterExtensionGlobal(app.ApplicationServices.GetService<ReportStorageWebExtension>());
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Default", action = "Index" }
                );
            });
            DemoUtils.DISPLAY_CODE = false;
            DemoUtils.SIMULATOR_NO_BORDER = true;
            DemoUtils.PRODUCT_CSS_BUNDLE_NAME = "reporting";
            DemoUtils.PRODUCT_THEME_CSS_TEMPLATE = "~/xtrareportsjs/css/dx-analytics.{0}.min.css";
        }
    }
}
