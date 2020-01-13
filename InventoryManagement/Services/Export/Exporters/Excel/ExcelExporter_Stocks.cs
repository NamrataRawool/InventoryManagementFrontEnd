using System;
using System.Collections.Generic;
using System.IO;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using OfficeOpenXml;

namespace InventoryManagement.Services.Export.Exporters.Excel
{
    class ExcelExporter_Stocks : IExcelExporter
    {
        public override void Export(string filename)
        {
            var stocks = DataService.GetStockDataController().GetAll();
            if (stocks == null)
                return;

            FileInfo excelFile = new FileInfo(filename);
            using (ExcelPackage excel = new ExcelPackage(excelFile))
            {
                ExcelWorksheet workSheet = excel.Workbook.Worksheets["Stocks"];
                if (workSheet == null)
                    workSheet = excel.Workbook.Worksheets.Add("Stocks");

                WriteHeader(workSheet);

                int row_index = 2; //  row-1 is the header
                for (int i = 0; i < stocks.Count; ++i)
                {
                    var stock = stocks[i];
                    int col_index = 1;

                    AddCell(workSheet, row_index, col_index++, stock.ID);
                    AddCell(workSheet, row_index, col_index++, stock.ProductID);
                    AddCell(workSheet, row_index, col_index++, stock.AvailableQuantity);
                    AddCell(workSheet, row_index, col_index++, stock.TotalQuantity);

                    ++row_index;
                }

                Save(excel, excelFile);
            }
        }

        protected override void WriteHeader(ExcelWorksheet worksheet)
        {
            int col_index = 1;

            AddCell(worksheet, 1, col_index++, "ID", true);
            AddCell(worksheet, 1, col_index++, "ProductID", true);
            AddCell(worksheet, 1, col_index++, "Available Quantity", true);
            AddCell(worksheet, 1, col_index++, "Total Quantity", true);
        }
    }
}
