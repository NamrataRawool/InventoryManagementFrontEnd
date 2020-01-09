﻿using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.Services.Export;
using InventoryManagement.Services.Misc.Assert;
using InventoryManagement.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace InventoryManagement
{

    public enum DBEntityType
    {
        PRODUCT,
        CATEGORY,
        STOCK,
        TRANSACTION,
        CUSTOMER,
        VENDOR,
        PURCHASE,
    }

    static class Program
    {

        private static void Initialize()
        {
            Assert.Enable();

            DataService.Get().Initialize();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }
    }
}
