using backend.Models;
using DotNetCore.DTOs.Stock;
using DotNetCore.Helpers;

namespace DotNetCore.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> CreateAyncs(Stock stockModel);
        Task<Stock?> UpdateAyncs(int id, UpdateStockDto stockDto);
        Task<Stock?> DeleteByIdAsync(int id); 
        Task<bool> StockExists(int id);
    }
}