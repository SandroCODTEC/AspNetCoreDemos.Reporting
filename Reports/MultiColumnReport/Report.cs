using System;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace AspNetCoreDemos.Reporting.Reports.MultiColumnReport {
    public partial class Report {
        static Report() {
            DevExpress.XtraReports.Expressions.ExpressionBindingDescriptor.SetPropertyDescription(typeof(DetailBand), "MultiColumn", new DevExpress.XtraReports.Expressions.ExpressionBindingDescription(new[] { "BeforePrint" }, 1000, new[] { "Layout" }));
            DevExpress.XtraReports.Expressions.ExpressionBindingDescriptor.SetPropertyDescription(typeof(Band), "PageBreak", new DevExpress.XtraReports.Expressions.ExpressionBindingDescription(new[] { "BeforePrint" }, 1000, new string[0]));
        }
        public Report() {
            InitializeComponent();
        }

        private void Report_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XtraReport report = sender as XtraReport;
            DetailBand detailBand = report.Bands[BandKind.Detail] as DetailBand;

            detailBand.MultiColumn.Layout = (bool)columnLayoutParameter.Value
                ? ColumnLayout.AcrossThenDown
                : ColumnLayout.DownThenAcross;
        }
    }
}
