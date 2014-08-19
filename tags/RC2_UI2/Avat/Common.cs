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
    }
}
