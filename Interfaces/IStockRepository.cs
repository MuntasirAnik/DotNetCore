using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using DotNetCore.DTOs.Stock;

namespace DotNetCore.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> CreateAyncs(Stock stockModel);
        Task<Stock?> UpdateAyncs(int id, UpdateStockDto stockDto);
        Task<Stock?> DeleteByIdAsync(int id); 
    }
}