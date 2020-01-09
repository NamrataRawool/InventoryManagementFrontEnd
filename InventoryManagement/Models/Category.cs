using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Services.Data.Database;

namespace InventoryManagement.Models
{
    public class CategoryBase
    {
        public CategoryBase() { }

        public CategoryBase(CategoryBase rhs)
        {
            CopyFrom(rhs);
        }

        public void CopyFrom(CategoryBase rhs)
        {
            ID = rhs.ID;
            Name = rhs.Name;
            Description = rhs.Description;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }

    public class CategoryPost : CategoryBase { }

    public class CategoryGet : CategoryBase
    {
        public CategoryGet() { }
        public CategoryGet(InventoryDbContext context, CategoryDTO categoryDTO)
            :base(categoryDTO)
        {
        }
    }

    public class CategoryDTO : CategoryBase
    {
        public CategoryDTO() { }

        public CategoryDTO(CategoryPost categoryPOST)
        {
            Name = categoryPOST.Name;
            Description = categoryPOST.Description;
        }
    }
}
