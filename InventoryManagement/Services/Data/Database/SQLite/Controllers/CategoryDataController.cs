using InventoryManagement.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services.Data.Database.SQLite.Controllers
{
    public class CategoryDataController : IDataController
    {
        public CategoryDataController(InventoryDbContext context) 
            : base(context)
        {
        }

        public CategoryGet Get(int id)
        {
            var productDTO = m_Context.GetCategory(id);
            return new CategoryGet(m_Context, productDTO);
        }

        public List<CategoryGet> GetAll()
        {
            var categoryDTOs = m_Context.Categories
                                .AsNoTracking()
                                .ToList();

            List<CategoryGet> outList = new List<CategoryGet>();
            foreach (var dto in categoryDTOs)
                outList.Add(new CategoryGet(m_Context, dto));

            return outList;
        }

        public CategoryGet GetByName(string name)
        {
            var dto = m_Context.Categories
                               .AsNoTracking()
                               .FirstOrDefaultAsync(c => c.Name.Equals(name))
                               .Result;

            return new CategoryGet(m_Context, dto);
        }

        public CategoryGet Post(CategoryPost post)
        {
            var dto = new CategoryDTO(post);
            m_Context.Categories.Add(dto);
            m_Context.SaveChanges();

            return new CategoryGet(m_Context, dto);
        }

        public CategoryGet Put(CategoryPost post)
        {
            var dto = m_Context.GetCategory(post.ID);
            dto.CopyFrom(post);

            m_Context.Entry(dto).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new CategoryGet(m_Context, dto);
        }
    }
}
