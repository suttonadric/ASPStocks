using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPStock.Website.Models;
using ASPStock.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ASPStock.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileStockServices StockService;
        public IEnumerable<Stock> Stocks { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileStockServices stockService)
        {
            _logger = logger;
            StockService = stockService;
        }

        public void OnGet()
        {
            Stocks = StockService.GetStocks();
        }
    }
}
