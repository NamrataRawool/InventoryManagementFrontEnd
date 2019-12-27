using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace InventoryManagement.Services.Export.Exporters.Excel
{
    public class ExcelExporter_Product : IExcelExporter
    {

        protected override void WriteHeader(ExcelWorksheet worksheet)
        {
            int col_index = 1;

            AddCell(worksheet, 1, col_index++, "ID", true);
            AddCell(worksheet, 1, col_index++, "Name", true);
            AddCell(worksheet, 1, col_index++, "Description", true);
            AddCell(worksheet, 1, col_index++, "Retail Price", true);
            AddCell(worksheet, 1, col_index++, "Wholesale Price", true);
            AddCell(worksheet, 1, col_index++, "Image Path", true);
            AddCell(worksheet, 1, col_index++, "Category ID", true);
        }

        public override void Export(string filename)
        {
            var products = HTTPService.GET<List<ProductGet>>("products");
            if (products == null)
                return;

            FileInfo excelFile = new FileInfo(filename);
            using (ExcelPackage excel = new ExcelPackage(excelFile))
            {
                ExcelWorksheet workSheet = excel.Workbook.Worksheets["Products"];
                if (workSheet == null)
                    workSheet = excel.Workbook.Worksheets.Add("Products");

                WriteHeader(workSheet);

                int row_index = 2; //  row-1 is the header
                for(int i = 0; i < products.Count; ++i)
                {
                    var product = products[i];
                    int col_index = 1;

                    AddCell(workSheet, row_index, col_index++, product.ID);
                    AddCell(workSheet, row_index, col_index++, product.Name);
                    AddCell(workSheet, row_index, col_index++, product.Description);
                    AddCell(workSheet, row_index, col_index++, product.RetailPrice);
                    AddCell(workSheet, row_index, col_index++, product.WholeSalePrice);
                    AddCell(workSheet, row_index, col_index++, product.ImagePath);
                    AddCell(workSheet, row_index, col_index++, product.Category.ID);

                    ++row_index;
                }

                Save(excel, excelFile);
            }

        }
    }
}
