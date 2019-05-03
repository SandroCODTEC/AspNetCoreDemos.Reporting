using System;
using DevExpress.XtraReports.UI;

namespace AspNetCoreDemos.Reporting.Reports.IListDataSource {
    public partial class Report {
        public string ConnectionString { get; set; }
        public Report() {
            InitializeComponent();
            var objectDataSource = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource() { DataSourceType = typeof(AspNetCoreDemos.Reporting.DataSources.VehiclesData.Vehicle) };
            //objectDataSource.BeforeFill += ObjectDataSource_BeforeFill;
            this.DataSource = objectDataSource;
            //this.DataSource = DataSources.VehiclesData.GetVehicles();
        }
        protected override void OnDataSourceDemanded(EventArgs e) {
            base.OnDataSourceDemanded(e);
            DataSource = DataSources.VehiclesData.GetVehicles(ConnectionString);
        }
    }
}
