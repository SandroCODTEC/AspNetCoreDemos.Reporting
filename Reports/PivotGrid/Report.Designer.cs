//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetCoreDemos.Reporting.Reports.PivotGrid
{
    
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        private void InitializeComponent() {
            DevExpress.XtraReports.ReportInitializer reportInitializer = new DevExpress.XtraReports.ReportInitializer(this, "AspNetCoreDemos.Reporting.Reports.PivotGrid.Report.repx");

            // Controls
            this.Detail = reportInitializer.GetControl<DevExpress.XtraReports.UI.DetailBand>("Detail");
            this.ReportHeader = reportInitializer.GetControl<DevExpress.XtraReports.UI.ReportHeaderBand>("ReportHeader");
            this.BottomMargin = reportInitializer.GetControl<DevExpress.XtraReports.UI.BottomMarginBand>("BottomMargin");
            this.topMarginBand1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.TopMarginBand>("topMarginBand1");
            this.xrPivotGrid1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPivotGrid>("xrPivotGrid1");
            this.fieldCountry = reportInitializer.GetPivotGridField("xrPivotGrid1", "fieldCountry");
            this.fieldSalesPerson = reportInitializer.GetPivotGridField("xrPivotGrid1", "fieldSalesPerson");
            this.fieldYear = reportInitializer.GetPivotGridField("xrPivotGrid1", "fieldYear");
            this.fieldQuarter = reportInitializer.GetPivotGridField("xrPivotGrid1", "fieldQuarter");
            this.fieldExtendedPrice = reportInitializer.GetPivotGridField("xrPivotGrid1", "fieldExtendedPrice");
            this.fieldQuantity = reportInitializer.GetPivotGridField("xrPivotGrid1", "fieldQuantity");
            this.fieldProductName = reportInitializer.GetPivotGridField("xrPivotGrid1", "fieldProductName");
            this.fieldCategoryName = reportInitializer.GetPivotGridField("xrPivotGrid1", "fieldCategoryName");
            this.fieldOrderID = reportInitializer.GetPivotGridField("xrPivotGrid1", "fieldOrderID");
            this.xrPictureBox1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPictureBox>("xrPictureBox1");
            this.xrPageInfo1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPageInfo>("xrPageInfo1");
            this.xrLabel2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("xrLabel2");

            // Data Sources
            this.sqlDataSource1 = reportInitializer.GetDataSource<DevExpress.DataAccess.Sql.SqlDataSource>("sqlDataSource1");

            // Styles
            this.xrPivotGridCellStyle = reportInitializer.GetStyle("xrPivotGridCellStyle");
            this.xrPivotGridFieldStyle = reportInitializer.GetStyle("xrPivotGridFieldStyle");
        }
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCountry;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldSalesPerson;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldYear;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldQuarter;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldExtendedPrice;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldQuantity;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldProductName;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCategoryName;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldOrderID;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRControlStyle xrPivotGridCellStyle;
        private DevExpress.XtraReports.UI.XRControlStyle xrPivotGridFieldStyle;
    }
}
