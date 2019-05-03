using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemos.Reporting {

    [Route("[action]")]
    public class DemosController : Controller {
        // Data binding
        public ActionResult PivotGridAndChart() {
            return View("_Viewer", "PivotGridAndChart");
        }
        public ActionResult CalculatedFields() {
            return View("_Viewer", "CalculatedFieldsReport");
        }
        public ActionResult CachedDocumentSource() {
            return View("_LargeDataset", "CachedDocumentSource");
        }

        // Report Types
        public ActionResult TableReport() {
            return View("_Viewer", "TableReport");
        }
        public ActionResult MasterDetailReport() {
            return View("_Viewer", "MasterDetailReport");
        }
        public ActionResult ProductLabelsReport() {
            return View("_Viewer", "ProductLabelsReport");
        }
        public ActionResult MergedReport() {
            return View("_ViewerWithoutDesignerButton", "ReportMerging.MergedReport");
        }
        public ActionResult SideBySideReports() {
            return View("_Viewer", "SideBySideReports.EmployeeComparisonReport");
        }
        public ActionResult Subreports() {
            return View("_Viewer", "Subreports.MasterReport");
        }
        public ActionResult MultiColumnReport() {
            return View("_Viewer", "MultiColumnReport");
        }

        // Interaction
        public ActionResult DrillDownReport() {
            return View("_Viewer", "DrillDownReport");
        }
        public ActionResult EmployeePerformanceReview() {
            return View("_Viewer", "EmployeePerformanceReview");
        }
        public ActionResult InteractiveSorting() {
            return View("_Viewer", "InteractiveSorting");
        }
        public ActionResult CharacterComb() {
            return View("_EFormReportViewer", "CharacterComb");
        }

        // Real-life Reports
        public ActionResult ProductListReport() {
            return View("_Viewer", "NorthwindTraders.ProductListReport");
        }
        public ActionResult CatalogReport() {
            return View("_Viewer", "NorthwindTraders.CatalogReport");
        }
        public ActionResult InvoiceReport() {
            return View("_Viewer", "NorthwindTraders.InvoiceReport");
        }
        public ActionResult SwissQRBill() {
            return View("_Viewer", "SwissQRBill");
        }
        public ActionResult ProfitAndLossReport() {
            return View("_Viewer", "ProfitAndLossReport");
        }

        // Layout Features
        public ActionResult ShrinkGrow() {
            return View("_Viewer", "ShrinkGrow");
        }
        public ActionResult AnchorVertical() {
            return View("_Viewer", "AnchorVertical");
        }
        public ActionResult HiddenColumns() {
            return View("_Viewer", "HiddenColumns");
        }

        //Report Controls
        public ActionResult Sparkline() {
            return View("_Viewer", "Sparkline");
        }
        public ActionResult BarCodeTypesReport() {
            return View("_Viewer", "BarCodeTypesReport");
        }
        public ActionResult Shape() {
            return View("_Viewer", "Shape");
        }
        public ActionResult Charts() {
            return View("_Viewer", "Charts");
        }
        public ActionResult PivotGrid() {
            return View("_Viewer", "PivotGrid");
        }
        public ActionResult CrossBandControls() {
            return View("_Viewer", "CrossBandControls");
        }

        // WebSpecificFeatures
        public ActionResult ReportDesigner(DemoReportModel model) {
            if(string.IsNullOrEmpty(model.ReportID))
                return View("_ReportDesigner", new DemoReportModel { ReportID = "MasterDetailReport" });
            return View("_ReportDesigner", model);

        }
        public ActionResult ColorSchemeCustomization() {
            return View("_ColorSchemeCustomizationViewer", "MasterDetailReport");
        }
    }
}
