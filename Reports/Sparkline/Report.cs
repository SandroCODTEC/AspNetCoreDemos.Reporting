using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace AspNetCoreDemos.Reporting.Reports.Sparkline
{
    public partial class Report
    {
        public Report()
        {
            InitializeComponent();
        }

        private void sparkline_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            List<double> values = new List<double>();
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach (string month in months)
                values.Add(GetCurrentColumnValue<double>(month));
            sparkline.DataSource = values;
        }
    }
}
