using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using ASPStock.Website.Models;
using Microsoft.AspNetCore.Hosting;

namespace ASPStock.WebSite.Services
{
    public class JsonFileStockServices
    {
        public JsonFileStockServices(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "simpleDB.json"); }
        }

        public IEnumerable<Stock> GetStocks()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Stock[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}