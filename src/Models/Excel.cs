using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Excel
    {
        public static async Task<Result<TEntity>> Write<TEntity>(string filename, Result<TEntity> data)
        {
            filename = filename.Replace(".xlsx", "");
            var file = new FileInfo($"{filename}.xlsx");

            DeleteIfExists(file);

            // Create excel
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using var package = new ExcelPackage(file);
            var ws = package.Workbook.Worksheets.Add($"All {nameof(TEntity)}s");
            List<TEntity> values = new();

            if (data.Value != null)
            {
                values = new List<TEntity>() { data.Value };
            }
            else if (data.Values != null)
            {
                values = data.Values;
            }

            // Write excel
            var range = ws.Cells["A1"].LoadFromCollection(values, true);
            range.AutoFitColumns();

            await package.SaveAsync();

            return data;
        }

        private static void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }
        }

    }
}
