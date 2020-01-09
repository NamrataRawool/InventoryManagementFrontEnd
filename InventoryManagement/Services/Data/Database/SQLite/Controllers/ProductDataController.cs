using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;

namespace InventoryManagement.Services.Data.Database.SQLite.Controllers
{
    public class ProductDataController : IDataController
    {
        
        public ProductDataController(InventoryDbContext context) 
            : base(context)
        {
        }

        public ProductGet Get(int id)
        {
            var productDTO = m_Context.GetProduct(id);
            return new ProductGet(m_Context, productDTO);
        }

        public List<ProductGet> GetAll()
        {
            var productDTOs = m_Context.Products
                                .AsNoTracking()
                                .ToList();

            List<ProductGet> outList = new List<ProductGet>();
            foreach (var dto in productDTOs)
                outList.Add(new ProductGet(m_Context, dto));

            return outList;
        }

        public ProductGet Post(ProductPost post)
        {
            var dto = new ProductDTO(post);

            m_Context.Products.Add(dto);
            m_Context.SaveChanges();

            string pathToSave = SaveImage(dto);
            dto.ImagePath = pathToSave;

            m_Context.Entry(dto).State = EntityState.Modified;
            m_Context.SaveChanges();

            return new ProductGet(m_Context, dto);
        }

        public ProductGet Put(ProductPost post)
        {
            var dto = m_Context.GetProduct(post.ID);
            dto.CopyFrom(post);

            string pathToSave = SaveImage(dto);
            dto.ImagePath = pathToSave;

            m_Context.Entry(dto).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new ProductGet(m_Context, dto);
        }

        // returns the path to save in the DB
        private string SaveImage(ProductDTO dto)
        {
            if (string.IsNullOrEmpty(dto.ImagePath))
                return string.Empty;

            string pathToSave = string.Empty;

            // get the filename

            string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string relativePath = "/media/products/images/" + dto.ID.ToString() + "/";

            directory += relativePath + "/";

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            string filename = Path.GetFileName(dto.ImagePath);

            // copy the image
            var finalPath = directory + filename;
            File.Copy(dto.ImagePath, finalPath, true);

            pathToSave = relativePath + filename;
            return pathToSave;
        }

    }
}
