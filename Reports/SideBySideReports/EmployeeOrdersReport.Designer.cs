//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetCoreDemos.Reporting.Reports.SideBySideReports
{
    
    public partial class EmployeeOrdersReport : DevExpress.XtraReports.UI.XtraReport {
        private void InitializeComponent() {
            DevExpress.XtraReports.ReportInitializer reportInitializer = new DevExpress.XtraReports.ReportInitializer(this, "AspNetCoreDemos.Reporting.Reports.SideBySideReports.EmployeeOrdersReport.repx");

            // Controls
            this.Detail = reportInitializer.GetControl<DevExpress.XtraReports.UI.DetailBand>("Detail");
            this.topMarginBand1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.TopMarginBand>("topMarginBand1");
            this.bottomMarginBand1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.BottomMarginBand>("bottomMarginBand1");
            this.DetailReport = reportInitializer.GetControl<DevExpress.XtraReports.UI.DetailReportBand>("DetailReport");
            this.Detail1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.DetailBand>("Detail1");
            this.xrTable1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTable>("xrTable1");
            this.xrTableRow1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableRow>("xrTableRow1");
            this.xrTableCell1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell1");
            this.xrTableCell2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell2");
            this.xrTableCell3 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell3");
            this.xrPictureBox1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPictureBox>("xrPictureBox1");
            this.xrTable3 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTable>("xrTable3");
            this.xrTableRow3 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableRow>("xrTableRow3");
            this.xrTableCell7 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell7");
            this.xrTableCell8 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell8");
            this.xrTableRow4 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableRow>("xrTableRow4");
            this.xrTableCell9 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell9");
            this.xrTableCell10 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell10");
            this.xrTableRow5 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableRow>("xrTableRow5");
            this.xrTableCell11 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell11");
            this.xrTableCell12 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell12");
            this.xrTableRow8 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableRow>("xrTableRow8");
            this.xrTableCell18 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell18");
            this.xrTableCell19 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell19");
            this.xrTableRow6 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableRow>("xrTableRow6");
            this.xrTableCell13 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell13");
            this.xrTableCell14 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell14");
            this.GroupHeader1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.GroupHeaderBand>("GroupHeader1");
            this.GroupFooter1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.GroupFooterBand>("GroupFooter1");
            this.xrTable2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTable>("xrTable2");
            this.xrTableRow2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableRow>("xrTableRow2");
            this.xrTableCell4 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell4");
            this.xrTableCell5 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell5");
            this.xrTableCell6 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell6");
            this.xrTable4 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTable>("xrTable4");
            this.xrTableRow7 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableRow>("xrTableRow7");
            this.xrTableCell15 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell15");
            this.xrTableCell16 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell16");
            this.xrTableCell17 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell17");

            // Parameters
            this.paramEmployeeID = reportInitializer.GetParameter("paramEmployeeID");

            // Data Sources
            this.dsEmployees1 = reportInitializer.GetDataSource<DevExpress.DataAccess.Sql.SqlDataSource>("dsEmployees1");
            this.sqlDataSource1 = reportInitializer.GetDataSource<DevExpress.DataAccess.Sql.SqlDataSource>("sqlDataSource1");

            // Styles
            this.EvenStyle = reportInitializer.GetStyle("EvenStyle");
            this.OddStyle = reportInitializer.GetStyle("OddStyle");
            this.Style1 = reportInitializer.GetStyle("Style1");
            this.Style2 = reportInitializer.GetStyle("Style2");
        }
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRControlStyle EvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle OddStyle;
        private DevExpress.XtraReports.Parameters.Parameter paramEmployeeID;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell18;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell19;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell17;
        private DevExpress.DataAccess.Sql.SqlDataSource dsEmployees1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Style1;
        private DevExpress.XtraReports.UI.XRControlStyle Style2;
    }
}
