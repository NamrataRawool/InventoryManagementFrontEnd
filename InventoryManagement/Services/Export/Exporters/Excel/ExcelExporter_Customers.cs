using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace InventoryManagement.Services.Export.Exporters.Excel
{
    public class ExcelExporter_Customers : IExcelExporter
    {

        protected override void WriteHeader(ExcelWorksheet worksheet)
        {
            int col_index = 1;

            AddCell(worksheet, 1, col_index++, "ID", true);
            AddCell(worksheet, 1, col_index++, "Name", true);
            AddCell(worksheet, 1, col_index++, "MobileNumber", true);
            AddCell(worksheet, 1, col_index++, "Email", true);
            AddCell(worksheet, 1, col_index++, "TotalAmount", true);
            AddCell(worksheet, 1, col_index++, "PendingAmount", true);
        }

        public override void Export(string filename)
        {
            var customers = DataService.GetCustomerDataController().GetAll();
            if (customers == null)
                return;

            FileInfo excelFile = new FileInfo(filename);
            using (ExcelPackage excel = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = excel.Workbook.Worksheets["Customers"];
                if (worksheet == null)
                    worksheet = excel.Workbook.Worksheets.Add("Customers");

                WriteHeader(worksheet);

                int row_index = 2; //  row-1 is the header
                for(int i = 0; i < customers.Count; ++i)
                {
                    var customer = customers[i];
                    int col_index = 1;

                    AddCell(worksheet, row_index, col_index++, customer.ID);
                    AddCell(worksheet, row_index, col_index++, customer.Name);
                    AddCell(worksheet, row_index, col_index++, customer.MobileNumber);
                    AddCell(worksheet, row_index, col_index++, customer.Email);
                    AddCell(worksheet, row_index, col_index++, customer.TotalAmount);
                    AddCell(worksheet, row_index, col_index++, customer.PendingAmount);

                    ++row_index;
                }

                Save(excel, excelFile);
            }

        }
    }
}
