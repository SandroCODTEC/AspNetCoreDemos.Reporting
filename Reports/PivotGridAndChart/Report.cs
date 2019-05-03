using System;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraReports.UI;

namespace AspNetCoreDemos.Reporting.Reports.PivotGridAndChart {
    public partial class Report : XtraReport {
        public Report() {
            InitializeComponent();
            parameterViewType.Type = typeof(ViewTypeFiltered);
            parameterViewType.Value = ViewTypeFiltered.StackedSplineArea;
            this.BeforePrint += Report_BeforePrint;
        }

        private void Report_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            xrChart.BeginInit();
            xrChart.SeriesTemplate.ChangeView((ViewType)parameterViewType.Value);
            bool labelsVisible = Convert.ToBoolean(parameterShowLabels.Value);
            xrChart.SeriesTemplate.LabelsVisibility = DefaultBooleanUtils.ToDefaultBoolean(labelsVisible);
            var diagram = xrChart.Diagram as Diagram3D;
            if(diagram != null && !labelsVisible) {
                diagram.ZoomPercent = 190;
                diagram.VerticalScrollPercent = 5;
            }
            xrPivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = Convert.ToBoolean(parameterShowRowGrandTotals.Value);
            xrPivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = Convert.ToBoolean(parameterShowColumnGrandTotals.Value);
            xrPivotGrid.OptionsChartDataSource.ProvideDataByColumns = Convert.ToBoolean(parameterGenerateSeriesFromColumns.Value);
            xrChart.EndInit();
        }
    }
}
