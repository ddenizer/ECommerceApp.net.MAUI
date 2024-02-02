using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.net.MAUI.Models
{
    public class OrderDetail
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("qyt")]
        public int Qyt { get; set; }

        [JsonProperty("subTotal")]
        public int SubTotal { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("productImage")]
        public string ProductImage { get; set; }

        [JsonProperty("productPrice")]
        public int ProductPrice { get; set; }
    }
}
