using System;
using DevExpress.XtraReports.UI;

namespace AspNetCoreDemos.Reporting.Reports.CustomDraw {
    public partial class Report {
        public Report() {
            InitializeComponent();
        }
        public int RegionID { get { return (int)RegionIdParameter.Value; } }

        private void Population_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            //UpdateControls();
            base.OnBeforePrint(e);
        }
        //void UpdateControls()
        //{
        //    using (var entities = new CountriesEntities())
        //    {
        //        var regions = (from region in entities.AboutRegions
        //                       where region.Id == RegionID
        //                       select region).ToList();
        //        xrLabel1.Text = regions.First().Region;
        //        customControl1.UpdateData(regions);
        //    }
        //}
    }
}
