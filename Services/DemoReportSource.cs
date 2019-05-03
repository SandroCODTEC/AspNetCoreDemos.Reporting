using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace AspNetCoreDemos.Reporting.Services {
    public class DemoReportSource : IDemoReportSource {
        Dictionary<string, Func<XtraReport>> predefinedReports = new Dictionary<string, Func<XtraReport>> {
            ["DrillDownReport"] = () => new Reports.DrillDown.Report(),
            ["InteractiveSorting"] = () => new Reports.InteractiveSorting.Report(),
            ["CharacterComb"] = () => new Reports.CharacterComb.Report(),
            ["TableReport"] = () => new Reports.TableReport.Report(),
            ["MasterDetailReport"] = () => new Reports.MasterDetailReport.Report(),
            ["Subreports.MasterReport"] = () => new Reports.Subreports.MasterReport(),
            ["MultiColumnReport"] = () => new Reports.MultiColumnReport.Report(),
            ["ProductLabelsReport"] = () => new Reports.BarCodes.ProductLabelsReport(),
            ["ReportMerging.MergedReport"] = () => new Reports.ReportMerging.MergedReport(),
            ["SideBySideReports.EmployeeComparisonReport"] = () => new Reports.SideBySideReports.EmployeeComparisonReport(),
            ["PivotGridAndChart"] = () => new Reports.PivotGridAndChart.Report(),
            ["HiddenColumns"] = () => new Reports.IListDataSource.Report(),
            ["CalculatedFieldsReport"] = () => new Reports.CalculatedFields.Report(),
            ["NorthwindTraders.ProductListReport"] = () => new Reports.NorthwindTraders.ProductListReport(),
            ["NorthwindTraders.CatalogReport"] = () => new Reports.NorthwindTraders.CatalogReport(),
            ["NorthwindTraders.InvoiceReport"] = () => new Reports.NorthwindTraders.InvoiceReport(),
            ["ProfitAndLossReport"] = () => new Reports.ProfitAndLoss.Report(),
            ["ShrinkGrow"] = () => new Reports.ShrinkGrow.Report(),
            ["MailMerge"] = () => new Reports.MailMerge.Report(),
            ["AnchorVertical"] = () => new Reports.AnchorVertical.Report(),
            ["Sparkline"] = () => new Reports.Sparkline.Report(),
            ["BarCodeTypesReport"] = () => new Reports.BarCodes.BarCodeTypesReport(),
            ["Shape"] = () => new Reports.Shape.Report(),
            ["Charts"] = () => new Reports.Charts.Report(),
            ["PivotGrid"] = () => new Reports.PivotGrid.Report(),
            ["CrossBandControls"] = () => new Reports.CrossBandControls.Report(),
            ["CustomDraw"] = () => new Reports.CustomDraw.Report(),
            ["FormattingRules"] = () => new Reports.FormattingRules.Report(),
            ["EmployeePerformanceReview"] = () => new Reports.EmployeePerformanceReview.Report(),
            ["SwissQRBill"] = () => new Reports.SwissQRBill.SwissQRBill(),
            ["CachedDocumentSource"] = () => new Reports.CachedDocumentSource.ReportWeb()
        };

        public Dictionary<string, string> GetReportList() {
            return predefinedReports.ToDictionary(i => i.Key, i => i.Key);
        }

        public XtraReport GetReport(string reportName) {
            return predefinedReports.ContainsKey(reportName) ? predefinedReports[reportName]() : null;
        }
    }
}
