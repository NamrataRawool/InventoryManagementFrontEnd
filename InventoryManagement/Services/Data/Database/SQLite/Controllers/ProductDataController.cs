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

            if (productDTO == null)
                return null;

            return new ProductGet(m_Context, productDTO);
        }

        public List<ProductGet> GetAll()
        {
            var productDTOs = m_Context.Products
                                .AsNoTracking()
                                .ToList();

            if (productDTOs == null)
                return null;

            List<ProductGet> outList = new List<ProductGet>();
            foreach (var dto in productDTOs)
                outList.Add(new ProductGet(m_Context, dto));

            return outList;
        }

        public ProductGet Post(ProductPost post)
        {
            var productDTO = new ProductDTO(post);

            m_Context.Products.Add(productDTO);
            m_Context.SaveChanges();

            string pathToSave = SaveImage(productDTO);
            productDTO.ImagePath = pathToSave;

            m_Context.Entry(productDTO).State = EntityState.Modified;
            m_Context.SaveChanges();

            if (productDTO == null)
                return null;

            return new ProductGet(m_Context, productDTO);
        }

        public ProductGet Put(ProductPost post, bool imageModified = true)
        {
            var productDTO = m_Context.GetProduct(post.ID);

            if (productDTO == null)
                return null;

            productDTO.CopyFrom(post);

            string pathToSave = SaveImage(productDTO, imageModified);
            productDTO.ImagePath = pathToSave;

            m_Context.Entry(productDTO).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new ProductGet(m_Context, productDTO);
        }

        // returns the path to save in the DB
        private string SaveImage(ProductDTO dto, bool imageModified = true)
        {
            if (!imageModified)
                return dto.ImagePath;

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
