using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Services.Misc.Assert;
using OfficeOpenXml;

namespace InventoryManagement.Services.Export.Exporters.Excel
{
    public class ExcelExporter_DataGridView : IExcelExporter
    {

        private DataGridView m_DataGridView = null;

        public override void Export(string filename)
        {
            FileInfo excelFile = new FileInfo(filename);
            using (ExcelPackage excel = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = excel.Workbook.Worksheets["Table"];
                if (worksheet == null)
                    worksheet = excel.Workbook.Worksheets.Add("Table");

                WriteHeader(worksheet);

                int numRows = m_DataGridView.Rows.Count;
                int row_index = 2; //  row 1 is the header
                for (int i = 0; i < numRows; ++i) //
                {
                    DataGridViewRow row = m_DataGridView.Rows[i];
                    WriteDataGridViewRow(worksheet, row_index, row);
                    ++row_index;
                }

                Save(excel, excelFile);
            }
        }

        protected override void WriteHeader(ExcelWorksheet worksheet)
        {
            int colIndex = 1;
            for (int i = 1; i < m_DataGridView.Columns.Count + 1; i++)
            {
                AddCell(worksheet, 1, colIndex, m_DataGridView.Columns[i - 1].HeaderText, true);
                ++colIndex;
            }
        }

        private void WriteDataGridViewRow(ExcelWorksheet worksheet, int rowIndex, DataGridViewRow row)
        {
            int colIndex = 1;
            int numColumns = m_DataGridView.ColumnCount;
            for (int i = 0; i < numColumns; ++i)
            {
                var cell = row.Cells[i];
                string value = cell.Value.ToString();

                AddCell(worksheet, rowIndex, colIndex++, value, true);
            }
        }

        public void SetDataGridView(DataGridView view)
        {
            m_DataGridView = view;
        }

    }
}
