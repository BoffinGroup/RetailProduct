using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class StockRepository: RepositoryBase<Stock>, IStockRepository
    {
        public StockRepository(RepositoryContext context):base(context)
        {

        }

        public void CreateStock(Stock stock)
        {
            Create(stock);
        }

        public void DeleteStock(Stock stock)
        {
            Delete(stock);
        }

        public async Task<IEnumerable<Stock>> GetAllStocksAsync()
        {
            return await FindAll().OrderBy(st => st.Name).ToListAsync();
        }

        public async Task<Stock> GetStockByIdAsync(int id)
        {
            return await FindByCondition(stk => stk.Id.Equals(id))
            .FirstOrDefaultAsync();
        }

        public async Task<Stock> GetStockWithDetailsAsync(int id)
        {
            return await FindByCondition(stock => stock.Id.Equals(id))
           .Include(ac => ac.Name)
           .FirstOrDefaultAsync();
        }     

        public void UpdateStock(Stock stock)
        {
            Update(stock);
        }
    }
}
