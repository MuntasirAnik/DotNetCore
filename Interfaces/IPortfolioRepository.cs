using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using DotNetCore.Models;

namespace DotNetCore.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<List<Stock>> GetUserPortfolio(User user);
        Task<Portfolio> CreateAsync(Portfolio portfolio);
    }
}