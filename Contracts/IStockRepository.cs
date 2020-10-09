using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;


namespace Contracts
{
    public interface IStockRepository : IRepositoryBase<Stock>
    {
        Task<IEnumerable<Stock>> GetAllStocksAsync();
        Task<Stock> GetStockByIdAsync(int id);
        Task<Stock> GetStockWithDetailsAsync(int id);
        void CreateStock(Stock stock);
        void UpdateStock(Stock stock);
        void DeleteStock(Stock stock);

    }
}
