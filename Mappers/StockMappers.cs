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
        public static StockDto ToStockDto(this Stock stoclModel)
        {
            return new StockDto
            {
                Id = stoclModel.Id,
                Symbol = stoclModel.Symbol,
                CompanyName = stoclModel.CompanyName,
                Purchase = stoclModel.Purchase,
                LastDiv = stoclModel.LastDiv,
                Industry = stoclModel.Industry,
                MarketCap = stoclModel.MarketCap
            };
        }

        public static Stock ToStockFromCreateDTO(this CreateStockDto stockDto)
        {
            return new Stock
            {
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                Purchase = stockDto.Purchase,
                LastDiv = stockDto.LastDiv,
                Industry = stockDto.Industry,
                MarketCap = stockDto.MarketCap
            };
        }
    }
}