using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using InventoryManagement.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

                var PostResponse = HTTPService.POST("product", pPost, files);
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

                var PostResponse = HTTPService.POST("category", cPost);
                Console.WriteLine(PostResponse.Name);
            }

            bool postCustomers = true;
            if (postCustomers)
            {
                CustomerPost cPost = new CustomerPost();
                cPost.Name = "Aditya Bhende";

                var PostResponse = HTTPService.POST("customer", cPost);
                Console.WriteLine(PostResponse.Name);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }
    }
}
