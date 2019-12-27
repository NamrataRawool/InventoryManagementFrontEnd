using InventoryManagement.Services.Export.Exporters.Excel;
using InventoryManagement.Services.Misc.Assert;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

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
            }

            Assert.Do("Invalid Exporter Name");
            return null;
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
