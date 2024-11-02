using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using DotNetCore.DTOs.Stock;

namespace DotNetCore.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stoclMpdel)
        {
            return new StockDto
            {
                Id = stoclMpdel.Id,
                Symbol = stoclMpdel.Symbol,
                CompanyName = stoclMpdel.CompanyName,
                Purchase = stoclMpdel.Purchase,
                LastDiv = stoclMpdel.LastDiv,
                Industry = stoclMpdel.Industry,
                MarketCap = stoclMpdel.MarketCap
            };
        }
    }
}