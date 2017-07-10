using AspNetCore_RestApiWithDapper.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_RestApiWithDapper.Contracts
{
    public class ProductResponse
    {
        public ProductResponse()
        {
            Products = new List<Product>();
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        public List<Product> Products { get; set; }
    }
}
