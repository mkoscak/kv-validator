using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Validators.TaxPayerValidator.Entities;
using AvatValidator.Validators.BlackListValidator.Entities;
using AvatValidator.Sql;
using OfficeOpenXml;
using System.Windows.Forms;
using System.Drawing;

namespace Avat
{
    public class Common
    {
        /*static List<TaxPayerEntity> TaxPayerCache;
        static Common()
        {
            RefreshCache();
        }

        public static void RefreshCache()
        {
            TaxPayerCache = TaxPayerEntity.LoadAll();
        }*/

        /// <summary>
        /// Nacitanie platitela DPH podla IC DPH
        /// </summary>
        /// <param name="icDph"></param>
        /// <returns></returns>
        public static TaxPayerEntity GetTaxPayer(string icDph)
        {
            if (string.IsNullOrEmpty(icDph))
                return null;

            var found = TaxPayerEntity.Load(string.Format("{0} = \"{1}\"", TaxPayerEntity.IC_DPH, icDph));
            //var found = TaxPayerCache.Where(t => t.IcDph == icDph).ToList();

            if (found == null || found.Count == 0 || found.Count > 1)
                return null;

            return found[0];
        }

        /// <summary>
        /// Nacitanie entity blacklistu podla ic dph
        /// </summary>
        /// <param name="icDph"></param>
        /// <returns></returns>
        public static BlackListEntity GetBlacklist(string icDph)
        {
            if (string.IsNullOrEmpty(icDph))
                return null;

            var found = BlackListEntity.Load(string.Format("{0} = \"{1}\"", BlackListEntity.IC_DPH, icDph));

            if (found == null || found.Count == 0 || found.Count > 1)
                return null;

            return found[0];
        }

        public static void ExportGridToExcel(ExcelWorksheet ws, DataGridView grid)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                // header
                var hCell = ws.Cells[1, i + 1];
                hCell.Value = grid.Columns[i].HeaderText;
                hCell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                hCell.Style.Fill.BackgroundColor.SetColor(Color.Wheat);
                hCell.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                for (int j = 0; j < grid.Rows.Count; j++)
                {
                    ws.Cells[j + 2, i + 1].Value = (grid[i, j].Value ?? string.Empty);
                }

                ws.Column(i + 1).AutoFit();
            }
        }

        public static void DrawRoundedRectangle(Graphics g/*, Color color*/, Rectangle rec, int radius,
                                            RoundedCorners corners, Brush b)
        {
            //using (var b = new SolidBrush(color))
            {
                int x = rec.X;
                int y = rec.Y;
                int diameter = radius * 2;
                var horiz = new Rectangle(x, y + radius, rec.Width, rec.Height - diameter);
                var vert = new Rectangle(x + radius, y, rec.Width - diameter, rec.Height);

                g.FillRectangle(b, horiz);
                g.FillRectangle(b, vert);

                if ((corners & RoundedCorners.TopLeft) == RoundedCorners.TopLeft)
                    g.FillEllipse(b, x, y, diameter, diameter);
                else
                    g.FillRectangle(b, x, y, diameter, diameter);

                if ((corners & RoundedCorners.TopRight) == RoundedCorners.TopRight)
                    g.FillEllipse(b, x + rec.Width - (diameter + 1), y, diameter, diameter);
                else
                    g.FillRectangle(b, x + rec.Width - (diameter + 1), y, diameter, diameter);

                if ((corners & RoundedCorners.BottomLeft) == RoundedCorners.BottomLeft)
                    g.FillEllipse(b, x, y + rec.Height - (diameter + 1), diameter, diameter);
                else
                    g.FillRectangle(b, x, y + rec.Height - (diameter + 1), diameter, diameter);

                if ((corners & RoundedCorners.BottomRight) == RoundedCorners.BottomRight)
                    g.FillEllipse(b, x + rec.Width - (diameter + 1), y + rec.Height - (diameter + 1), diameter, diameter);
                else
                    g.FillRectangle(b, x + rec.Width - (diameter + 1), y + rec.Height - (diameter + 1), diameter,
                                    diameter);
            }
        }

        public enum RoundedCorners
        {
            None = 0x00,
            TopLeft = 0x02,
            TopRight = 0x04,
            BottomLeft = 0x08,
            BottomRight = 0x10,
            All = 0x1F
        }

        public static void DrawRoundedRectangle(Graphics g, Rectangle r, int d, Brush b)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DrawRoundedRectangle(g, r, d, RoundedCorners.All, b);
            /*System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddArc(r.X, r.Y - 1, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y - 1, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            gp.AddLine(r.X - 1, r.Y + r.Height - d, r.X - 1, r.Y + d / 2);
            g.FillPath(b, gp);
            gp.Dispose();*/
        }
    }
}
