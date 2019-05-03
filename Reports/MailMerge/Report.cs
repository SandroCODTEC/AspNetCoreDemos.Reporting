using System;
using DevExpress.XtraReports.UI;

namespace AspNetCoreDemos.Reporting.Reports.MailMerge {
    public partial class Report {
        public Report() {
            InitializeComponent();
        }

        private void Report1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            const string wrongString = " and reports to ";
            if(string.IsNullOrEmpty(GetCurrentColumnValue("ReportsToInfo") as string))
                xrRichText1.Rtf = xrRichText1.Rtf.Replace(wrongString, string.Empty);
        }
    }
}
