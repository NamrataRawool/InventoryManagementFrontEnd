using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class VendorBase
    {
        [Key]
        [JsonProperty]
        public int ID { get; set; }

        [Required]
        [JsonProperty]
        public string CompanyName { get; set; }

        [JsonProperty]
        public string Email { get; set; }

        [JsonProperty]
        public string MobileNumber { get; set; }

        [JsonProperty]
        public string Address { get; set; }

        [JsonProperty]
        public string City { get; set; }

        [JsonProperty]
        public string State { get; set; }
    }

    public class VendorGet : VendorBase
    {
    }

    public class VendorPost : VendorBase
    {
    }
}
