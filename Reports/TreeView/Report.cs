using System;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace AspNetCoreDemos.Reporting.Reports.TreeView {
    public partial class Report {
        [
        Browsable(false),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
        ]
        public DevExpress.XtraReports.UI.PrintableComponentContainer WinControlContainer {
            get { return this.winControlContainer1; }
        }
        public Report() {
            InitializeComponent();
        }
    }
}
