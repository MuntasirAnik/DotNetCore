using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using DotNetCore.DTOs.Stock;
using DotNetCore.Interfaces;
using DotNetCore.Mappers;
using Newtonsoft.Json;

namespace DotNetCore.Services
{
    public class FMPService : IFMPService
    {
        private HttpClient _httpClient;
        private IConfiguration _config;
        public FMPService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
        }
        public async Task<Stock> FindStockBySymbolAsync(string symbol)
        {
            try {
                var result = await _httpClient.GetAsync($"https://financialmodelingprep.com/api/v3/profile/{symbol}?apikey={_config["FMPKey"]}");
                if(result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var task = JsonConvert.DeserializeObject<FMPStock[]>(content);
                    var stock = task[0];
                    if(stock != null)
                    {
                        return stock.ToStockFromFMP();
                    }
                    return null;
                }
                return null;

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}