using InventoryManagement.Models;
using InventoryManagement.Services.Export;
using InventoryManagement.Services.HTTP;
using InventoryManagement.Services.Misc.Assert;
using InventoryManagement.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace InventoryManagement
{
    static class Program
    {

        private static void TestGET()
        {
            // GET
            var Categories = HTTPService.GET<List<CategoryGet>>("categories");
            Console.WriteLine("Number of Products in DB: " + Categories.Count);


            var Product = HTTPService.GET<ProductGet>("product/32");
            Console.WriteLine(Product.Name);

            var Customers = HTTPService.GET<List<CustomerGet>>("customers");
            Console.WriteLine(Customers.Count);

        }

        private static void TestPOST()
        {
            bool postProduct = false;
            if (postProduct)
            {
                List<string> files = new List<string>();
                files.Add("C:/Users/ASUS ROG/Desktop/passport photo.jpg");

                ProductPost pPost = new ProductPost();
                pPost.Name = "test name";
                pPost.Description = "test description";
                pPost.RetailPrice = 100;
                pPost.WholeSalePrice = 98;
                pPost.CategoryID = 1;

                var PostResponse = HTTPService.POST<ProductGet, ProductPost>("product", pPost, files);
                Console.WriteLine(PostResponse.Name);
            }

            bool postCategory = false;
            if (postCategory)
            {
                CategoryPost cPost = new CategoryPost();
                cPost.Name = "test name";
                cPost.Description = "test Description";
                cPost.CGST = 12.6;
                cPost.SGST = 12.6;
                cPost.Discount = 10;

                var PostResponse = HTTPService.POST<CategoryGet, CategoryPost>("category", cPost);
                Console.WriteLine(PostResponse.Name);
            }

            bool postCustomers = false;
            if (postCustomers)
            {
                CustomerPost cPost = new CustomerPost();
                cPost.Name = "Aditya Bhende";

                var PostResponse = HTTPService.POST<CustomerGet, CustomerPost>("customer", cPost);
                Console.WriteLine(PostResponse.Name);
            }

            bool postStock = true;
            if(postStock)
            {
                StockPost stock = new StockPost();
                stock.ProductID = 1;
                stock.AvailableQuantity = 1;
                stock.TotalQuantity = 1;

                var PostResponse = HTTPService.POST<StockGet, StockPost>("stock", stock);
                Console.WriteLine(PostResponse.ID);
            }
        }

        private static void TestEXPORT()
        {
            var products_exporter = ExportManager.Get().CreateExporter(ExportType.EXCEL, ExportEntity.PRODUCTS);
            products_exporter.Export("C:/Users/Aditya.Bhende/Desktop/inventory.xlsx");

            var customer_exporter = ExportManager.Get().CreateExporter(ExportType.EXCEL, ExportEntity.CUSTOMERS);
            customer_exporter.Export("C:/Users/Aditya.Bhende/Desktop/inventory.xlsx");

            var categories_exporter = ExportManager.Get().CreateExporter(ExportType.EXCEL, ExportEntity.TRANSACTIONS);
            categories_exporter.Export("C:/Users/Aditya.Bhende/Desktop/inventory.xlsx");

            var stocks_exporter = ExportManager.Get().CreateExporter(ExportType.EXCEL, ExportEntity.STOCKS);
            stocks_exporter.Export("C:/Users/Aditya.Bhende/Desktop/inventory.xlsx");

        }

        private static void InitializeHttpControllers()
        {
            // TEMP : to initialize all the HttpControllers
            HTTPService.GET<List<ProductGet>>("products");
            HTTPService.GET<List<ProductGet>>("categories");
            HTTPService.GET<List<ProductGet>>("transactions");
            HTTPService.GET<List<ProductGet>>("stocks");
            HTTPService.GET<List<ProductGet>>("purchases");
            HTTPService.GET<List<ProductGet>>("vendors");
        }

        private static void Initialize()
        {
            Assert.Enable();
            //InitializeHttpControllers();
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
