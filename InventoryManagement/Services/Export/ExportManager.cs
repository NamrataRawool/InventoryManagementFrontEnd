using InventoryManagement.Services.Export.Exporters.Excel;
using InventoryManagement.Services.Misc.Assert;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace InventoryManagement.Services.Export
{

    class ExportManager
    {

        public IExporter CreateExporter(ExportType type, ExportEntity export_entity)
        {
            switch (type)
            {
                case ExportType.EXCEL:
                    return CreateExcelExporter(export_entity);
            }

            Assert.Do("Export Type not supported yet!");
            return null;
        }

        private IExporter CreateExcelExporter(ExportEntity export_entity)
        {

            switch (export_entity)
            {
                case ExportEntity.PRODUCTS:
                    return new ExcelExporter_Product();
                case ExportEntity.CATEGORIES:
                    return new ExcelExporter_Categories();
                case ExportEntity.CUSTOMERS:
                    return new ExcelExporter_Customers();
                case ExportEntity.TRANSACTIONS:
                    return new ExcelExporter_Transactions();
                case ExportEntity.STOCKS:
                    return new ExcelExporter_Stocks();
                case ExportEntity.DATAGRIDVIEW:
                    return new ExcelExporter_DataGridView();
            }

            Assert.Do("Invalid Exporter Name");
            return null;
        }

        private void ExportDataGridViewToExcel(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count < 1)
            {
                MessageBox.Show("Nothing to export!");
                return;
            }

            // open file selection dialog
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "*.xlsx|*.xlsx";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;

            DialogResult dialogResult = dialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return;

            string filename = dialog.FileName;

            var exporter = (ExcelExporter_DataGridView)ExportManager.Get().CreateExporter(ExportType.EXCEL, ExportEntity.DATAGRIDVIEW);
            exporter.SetDataGridView(dataGridView);

            exporter.Export(filename);

            MessageBox.Show("File exported : " + filename);
        }

        public void ExportDataGridView(DataGridView dataGridView, ExportType type)
        {
            if (type == ExportType.EXCEL)
                ExportDataGridViewToExcel(dataGridView);
        }

        public static ExportManager Get()
        {
            if (m_Instance == null)
                m_Instance = new ExportManager();
            return m_Instance;
        }

        private static ExportManager m_Instance;
    }
}
