using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Export.Exporters.Excel
{

    public abstract class IExcelExporter : IExporter
    {
        public override ExportType Type()
        {
            return ExportType.EXCEL;
        }

        protected abstract void WriteHeader(ExcelWorksheet worksheet);

        protected void AddCell(ExcelWorksheet worksheet, int row_index, int col_index, object value, bool is_header = false)
        {
            var cell = worksheet.Cells[row_index, col_index];
            cell.Value = value;
            cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            cell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            cell.Style.ShrinkToFit = false;
            cell.AutoFitColumns();

            if (is_header)
                cell.Style.Border.BorderAround(ExcelBorderStyle.Thick);

        }

        protected void Save(ExcelPackage excel, FileInfo fileInfo)
        {
            if (fileInfo.Exists)
                excel.Save();
            else
                excel.SaveAs(fileInfo);
        }
    }
}
