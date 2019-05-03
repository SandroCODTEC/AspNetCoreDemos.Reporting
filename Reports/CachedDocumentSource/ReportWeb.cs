using System;
using DevExpress.XtraReports.UI;

namespace AspNetCoreDemos.Reporting.Reports.CachedDocumentSource {
    public partial class ReportWeb {
        public ReportWeb() {
            InitializeComponent();
            RowCountParameter.Value = 2500u;
        }
    }
}
