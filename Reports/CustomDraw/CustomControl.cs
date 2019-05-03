using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using System.Drawing;
using DevExpress.XtraPrinting;
using DevExpress.DemoData.Models;

namespace AspNetCoreDemos.Reporting.Reports.CustomDraw {
    public class CustomControl : XRControl {
        object[,] controlData = { { "", 1.0 } };
        public void UpdateData(IList<AboutRegion> regions) {
            controlData = new object[Math.Min(regions.Count, 10), 2];
            for(int i = 0; i < controlData.GetLength(0); i++) {
                double population = regions[i].PopulationPortion;
                string country = string.Format("{0}, {1:p}", regions[i].Country, population);
                controlData.SetValue(country, i, 0);
                controlData.SetValue(population, i, 1);
            }

        }
        protected override VisualBrick CreateBrick(VisualBrick[] childrenBricks) {
            return new PanelBrick(this);
        }
        protected override void PutStateToBrick(VisualBrick brick, PrintingSystemBase ps) {
            base.PutStateToBrick(brick, ps);
            float itemHeight = GetItemHeight(brick.Rect);
            RectangleF r = GetGraphicsRect(brick.Rect, itemHeight);
            double scale = GetScale();
            for(int i = 0; i <= controlData.GetUpperBound(0); i++) {
                DrawPopulationInfo((PanelBrick)brick, r, (string)controlData[i, 0], (double)controlData[i, 1], scale);
                r.Offset(0, itemHeight);
            }
        }
        float GetItemHeight(RectangleF bounds) {
            return bounds.Height / (controlData.GetUpperBound(0) + 1);
        }
        double GetScale() {
            return 1 / (double)controlData[0, 1];
        }
        static RectangleF GetGraphicsRect(RectangleF bounds, float itemHeight) {
            const int indent = 10;
            RectangleF r = new RectangleF(0, 0, bounds.Width, itemHeight);
            r.Inflate(-2 * indent, -indent);
            return r;
        }
        static void DrawPopulationInfo(PanelBrick panel, RectangleF r, string text, double portion, double scale) {
            RectangleF barRect = GetBarRect(r, portion, scale);
            r.Height = barRect.Top - r.Top;

            TextBrick textBrick = new TextBrick();
            textBrick.Sides = BorderSide.None;
            textBrick.BackColor = panel.BackColor;
            textBrick.Rect = r;
            textBrick.ForeColor = panel.Style.ForeColor;
            textBrick.Text = text;
            textBrick.Font = panel.Style.Font;
            textBrick.Padding = new PaddingInfo(1, 0, 0, 0);
            textBrick.StringFormat = panel.Style.StringFormat;
            panel.Bricks.Add(textBrick);

            VisualBrick barBrick = new VisualBrick();
            barBrick.Sides = BorderSide.All;
            barBrick.BackColor = Color.FromArgb(232, 216, 195);
            barBrick.Rect = barRect;
            barBrick.BorderColor = Color.FromArgb(173, 148, 116);
            barBrick.BorderStyle = BrickBorderStyle.Inset;
            panel.Bricks.Add(barBrick);
        }
        static RectangleF GetBarRect(RectangleF r, double portion, double scale) {
            float barWidth = (float)(r.Width * portion * scale);
            float barHeight = (float)((double)r.Height / 3.0);
            return new RectangleF(r.Left, r.Bottom - barHeight, barWidth, barHeight);
        }
    }
}
