using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;

namespace AspNetCoreDemos.DemoShell {

    public static class DemoUtils {
        public static bool DISPLAY_CODE = true;
        public static bool SIMULATOR_NO_BORDER = false;
        public static string PRODUCT_CSS_BUNDLE_NAME = null;
        public static string PRODUCT_THEME_CSS_TEMPLATE = null;

        public static void SetLayout(IRazorPage page) {
            if(IsNavigationEnabled(page.ViewContext.HttpContext))
                page.Layout = "~/DemoShell/Views/_LayoutNavigation.cshtml";
            else
                page.Layout = "~/DemoShell/Views/_Layout.cshtml";
        }

        public static string GetCurrentTheme(HttpContext http) {
            var theme = http.Request.Query["theme"];

            if(!string.IsNullOrEmpty(theme))
                return theme;

            return "light";
        }

        public static string GetCurrentDevice(HttpContext http) {
            if(GetCurrentTheme(http).StartsWith("ios"))
                return "iPhone";

            return "desktop";
        }

        public static bool IsNavigationEnabled(HttpContext http) {
            return !http.Request.Query.ContainsKey("onlyview");
        }

        public static string KeepQueryString(string urlWithoutQueryString, HttpRequest req, params string[] names) {
            var query = new QueryString();
            foreach(var name in names) {
                if(req.Query.ContainsKey(name))
                    query = query.Add(name, req.Query[name]);
            }

            if(query.HasValue)
                return urlWithoutQueryString + query;

            return urlWithoutQueryString;
        }
    }

}
