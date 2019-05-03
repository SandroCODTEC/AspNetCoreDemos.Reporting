using System;
using System.Collections.Generic;
using System.IO;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace AspNetCoreDemos.Reporting.Services {
    public class DemoReportStorageWebExtension : ReportStorageWebExtension {
        protected IHostingEnvironment Environment { get; }
        protected IHttpContextAccessor HttpContextAccessor { get; }
        protected IDemoReportSource PredefinedReports { get; }

        public DemoReportStorageWebExtension(IHostingEnvironment env, IHttpContextAccessor httpContextAccessor, IDemoReportSource reportFactory) {
            Environment = env;
            HttpContextAccessor = httpContextAccessor;
            PredefinedReports = reportFactory;
        }

        public override bool CanSetData(string url) {
            return true;
        }

        public override bool IsValidUrl(string url) {
            return true;
        }

        public override byte[] GetData(string url) {
            byte[] reportBytes;
            if(HttpContextAccessor.HttpContext.Session.TryGetValue(url, out reportBytes)) {
                return reportBytes;
            }
            XtraReport report = PredefinedReports.GetReport(url);
            if(report == null) {
                throw new Exception("Report was not found.");
            }

            using(var stream = new MemoryStream()) {
                report.SaveLayoutToXml(stream);
                report.Dispose();
                return stream.ToArray();
            }
        }

        public override Dictionary<string, string> GetUrls() {
            return PredefinedReports.GetReportList();
        }

        public override void SetData(XtraReport report, string url) {
            using(var stream = new MemoryStream()) {
                report.SaveLayoutToXml(stream);
                HttpContextAccessor.HttpContext.Session.Set(url, stream.ToArray());
            }
        }

        public override string SetNewData(XtraReport report, string defaultUrl) {
            using(var stream = new MemoryStream()) {
                report.SaveLayoutToXml(stream);
                HttpContextAccessor.HttpContext.Session.Set(defaultUrl, stream.ToArray());
            }
            return defaultUrl;
        }
    }
}
