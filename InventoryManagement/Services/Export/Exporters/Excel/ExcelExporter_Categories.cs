using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;

namespace InventoryManagement.Services.Export.Exporters.Excel
{
    public class ExcelExporter_Categories : IExcelExporter
    {

        protected override void WriteHeader(ExcelWorksheet worksheet)
        {
            int col_index = 1;

            AddCell(worksheet, 1, col_index++, "ID", true);
            AddCell(worksheet, 1, col_index++, "Name", true);
            AddCell(worksheet, 1, col_index++, "Description", true);
            AddCell(worksheet, 1, col_index++, "Discount", true);
            AddCell(worksheet, 1, col_index++, "CGST", true);
            AddCell(worksheet, 1, col_index++, "SGST", true);
        }

        public override void Export(string filename)
        {
            var Categories = DataService.GetCategoryDataController().GetAll();
            if (Categories == null)
                return;

            FileInfo excelFile = new FileInfo(filename);
            using (ExcelPackage excel = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = excel.Workbook.Worksheets["Categories"];
                if (worksheet == null)
                    worksheet = excel.Workbook.Worksheets.Add("Categories");

                WriteHeader(worksheet);

                int row_index = 2; //  row-1 is the header
                for(int i = 0; i < Categories.Count; ++i)
                {
                    var category = Categories[i];
                    int col_index = 1;

                    AddCell(worksheet, row_index, col_index++, category.ID);
                    AddCell(worksheet, row_index, col_index++, category.Name);
                    AddCell(worksheet, row_index, col_index++, category.Description);

                    ++row_index;
                }

                Save(excel, excelFile);
            }

        }
    }
}
