using System;
using DevExpress.XtraReports.UI;

namespace AspNetCoreDemos.Reporting.Reports.ReportMerging {
    public class MergedReport : NorthwindTraders.CatalogReport {
        long? categoryStartPageID;
        Charts.Report fChartsReport;

        public Charts.Report ChartsReport {
            get {
                if(fChartsReport == null) {
                    fChartsReport = new Charts.Report();
                    fChartsReport.RemoveReportHeader();
                    fChartsReport.CreateDocument();
                }
                return fChartsReport;
            }
        }

        public MergedReport() {
            Name = "ReportMergingReport";
            DisplayName = "Report Merging";
            GroupHeader.PageBreak = PageBreak.BeforeBand;
            lbCategoryName.PrintOnPage += lbCategoryName_PrintOnPage;
            AfterPrint += Report1_AfterPrint;
        }
        protected override bool EnableGroupsSorting {
            get { return false; }
        }
        private void Report1_AfterPrint(object sender, EventArgs e) {
            if(IsDisposed || categoryStartPageID == null)
                return;

            ModifyDocument(x => {
                int categoryStartPageIndex = x.GetPageIndexByID(categoryStartPageID.Value);
                categoryStartPageID = null;

                for(int i = 0; i < ChartsReport.Pages.Count; i++) {
                    int insertIndex = categoryStartPageIndex + 1 + i * 2;
                    if(insertIndex >= x.PageCount)
                        break;
                    x.InsertPage(insertIndex, ChartsReport.Pages[i]);
                }
            });
        }
        protected override void Dispose(bool disposing) {
            if(disposing) {
                AfterPrint -= Report1_AfterPrint;
                lbCategoryName.PrintOnPage -= lbCategoryName_PrintOnPage;
                if(fChartsReport != null) {
                    fChartsReport.Dispose();
                    fChartsReport = null;
                }
            }
            base.Dispose(disposing);
        }
        private void lbCategoryName_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            if(IsDisposed || categoryStartPageID != null)
                return;
            categoryStartPageID = Pages[e.PageIndex].ID;
        }
    }
}
