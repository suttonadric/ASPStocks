using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASPStock.Website.Models
{
    public class Stock
    {
        [JsonPropertyName("symbol")]
        public string symbol { get; set; }

        [JsonPropertyName("price")]
        public double price { get; set; }
        public int buyRating { get; set; }


        public override string ToString()
        {
            return JsonSerializer.Serialize<Stock>(this);
        }
    }

    
}
