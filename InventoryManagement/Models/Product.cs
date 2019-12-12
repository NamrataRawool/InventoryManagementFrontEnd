using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class Product
    {
        [Key]
        [JsonProperty]
        public int ID
        {
            get;
            set;
        }
        [Required]
        [JsonProperty]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty]
        public string Description
        {
            get;
            set;
        }

        [Required]
        [JsonProperty]
        public int RetailPrice
        {
            get;
            set;
        }
        [Required]
        [JsonProperty]
        public int WholeSalePrice
        {
            get;
            set;
        }
        [Required]
        [JsonProperty]
        public int CategoryID
        {
            get;
            set;
        }
     //   [JsonProperty]
        //public List<IFormFile> Images
        //{
        //    get;
        //    set;
        //}
    }
}
