using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace InventoryManagement.Services.Export.Exporters.Excel
{
    public class ExcelExporter_Transactions : IExcelExporter
    {

        protected override void WriteHeader(ExcelWorksheet worksheet)
        {
            int col_index = 1;

            AddCell(worksheet, 1, col_index++, "ID", true);
            AddCell(worksheet, 1, col_index++, "ProductIDS", true);
            AddCell(worksheet, 1, col_index++, "ProductQuantity", true);
            AddCell(worksheet, 1, col_index++, "Date", true);
            AddCell(worksheet, 1, col_index++, "Customer", true);
        }

        public override void Export(string filename)
        {
            var transactions = DataService.GetTransactionDataController().GetAll();
            if (transactions == null)
                return;

            FileInfo excelFile = new FileInfo(filename);
            using (ExcelPackage excel = new ExcelPackage(excelFile))
            {
                ExcelWorksheet workSheet = excel.Workbook.Worksheets["Transactions"];
                if (workSheet == null)
                    workSheet = excel.Workbook.Worksheets.Add("Transactions");

                WriteHeader(workSheet);

                int row_index = 2; //  row-1 is the header
                for(int i = 0; i < transactions.Count; ++i)
                {
                    var transaction = transactions[i];
                    int col_index = 1;

                    AddCell(workSheet, row_index, col_index++, transaction.ID);
                    AddCell(workSheet, row_index, col_index++, transaction.ProductIDs);
                    AddCell(workSheet, row_index, col_index++, transaction.ProductQuantity);
                    AddCell(workSheet, row_index, col_index++, transaction.TransactionDateTime.ToString());
                    AddCell(workSheet, row_index, col_index++, transaction.Customer.Name);

                    ++row_index;
                }

                Save(excel, excelFile);
            }

        }
    }
}
