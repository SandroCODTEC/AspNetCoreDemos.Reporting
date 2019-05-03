using System;
using DevExpress.XtraReports.UI;

namespace AspNetCoreDemos.Reporting.Reports.NorthwindTraders {
    public partial class CatalogReport {

        public CatalogReport() {
            InitializeComponent();

            parameterSortGroupsType.Type = typeof(SortGroupsType);
            parameterSortGroupsType.Value = SortGroupsType.Count;
            parameterSortGroupsType.Visible = EnableGroupsSorting;
            parameterSortGroupsOrder.Type = typeof(XRColumnSortOrder);
            parameterSortGroupsOrder.Value = XRColumnSortOrder.Ascending;
            parameterSortGroupsOrder.Visible = EnableGroupsSorting;

            UpdateGroupSortingSummary();
        }
        public GroupHeaderBand GroupHeader { get { return GroupHeader0; } }
        protected virtual bool EnableGroupsSorting { get { return true; } }
        void UpdateGroupSortingSummary() {
            GroupHeader0.SortingSummary.Enabled = EnableGroupsSorting;
            GroupHeader0.SortingSummary.FieldName = "UnitPrice";//dsCatalog1.Products.UnitPriceColumn.ColumnName;
            GroupHeader0.SortingSummary.SortOrder = (XRColumnSortOrder)parameterSortGroupsOrder.Value;
            GroupHeader0.SortingSummary.IgnoreNullValues = true;

            switch((SortGroupsType)parameterSortGroupsType.Value) {
                case SortGroupsType.None:
                    GroupHeader0.SortingSummary.Enabled = false;
                    break;
                case SortGroupsType.Count:
                    GroupHeader0.SortingSummary.Function = SortingSummaryFunction.Count;
                    break;
                case SortGroupsType.TotalSales:
                    GroupHeader0.SortingSummary.Function = SortingSummaryFunction.Sum;
                    GroupHeader0.SortingSummary.FieldName = "ProductSales";
                    break;
                case SortGroupsType.LowestPrice:
                    GroupHeader0.SortingSummary.Function = SortingSummaryFunction.Min;
                    break;
                case SortGroupsType.HighestPrice:
                    GroupHeader0.SortingSummary.Function = SortingSummaryFunction.Max;
                    break;
            }
        }
        protected override void OnBeforePrint(System.Drawing.Printing.PrintEventArgs e) {
            base.OnBeforePrint(e);
            UpdateGroupSortingSummary();
        }
    }
}
