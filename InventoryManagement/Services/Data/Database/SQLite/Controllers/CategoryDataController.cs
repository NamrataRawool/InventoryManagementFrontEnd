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
            var categoryDTO = m_Context.GetCategory(id);

            if (categoryDTO == null)
                return null;

            return new CategoryGet(m_Context, categoryDTO);
        }

        public List<CategoryGet> GetAll()
        {
            var categoryDTOs = m_Context.Categories
                                .AsNoTracking()
                                .ToList();

            if (categoryDTOs == null)
                return null;

            List<CategoryGet> outList = new List<CategoryGet>();
            foreach (var dto in categoryDTOs)
                outList.Add(new CategoryGet(m_Context, dto));

            return outList;
        }

        public CategoryGet GetByName(string name)
        {
            var categoryDTO = m_Context.Categories
                               .AsNoTracking()
                               .FirstOrDefaultAsync(c => c.Name.Equals(name))
                               .Result;

            if (categoryDTO == null)
                return null;

            return new CategoryGet(m_Context, categoryDTO);
        }

        public CategoryGet Post(CategoryPost post)
        {
            var categoryDTO = new CategoryDTO(post);
            m_Context.Categories.Add(categoryDTO);
            m_Context.SaveChanges();

            if (categoryDTO == null)
                return null;

            return new CategoryGet(m_Context, categoryDTO);
        }

        public CategoryGet Put(CategoryPost post)
        {
            var categoryDTO = m_Context.GetCategory(post.ID);

            if (categoryDTO == null)
                return null;

            categoryDTO.CopyFrom(post);

            m_Context.Entry(categoryDTO).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new CategoryGet(m_Context, categoryDTO);
        }
    }
}
