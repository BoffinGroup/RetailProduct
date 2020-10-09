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
    public class PurchaseRepository: RepositoryBase<Purchase>, IPurchaseRepository
    {

        public PurchaseRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }

       // All the logic function relating to Purchases will be implemented here

        public void CreatePurchase(Purchase purchase)
        {
            Create(purchase);
        }

        public void DeletePurchase(Purchase purchase)
        {
            Delete(purchase);
        }

        public async Task<IEnumerable<Purchase>> GetAllPurchasesAsync()
        {
            return await FindAll().OrderBy(st => st.Id).ToListAsync();
        }

        public async Task<Purchase> GetPurchaseByIdAsync(int id)
        {
            return await FindByCondition(stk => stk.Id.Equals(id))
            .FirstOrDefaultAsync();
        }

        public async Task<Purchase> GetPurchaseWithDetailsAsync(int id)
        {
            return await FindByCondition(stock => stock.Id.Equals(id))
           .Include(ac => ac.Id)
           .FirstOrDefaultAsync();
        }

        public void UpdatePurchase(Purchase purchase)
        {
            Update(purchase);
        }
    }
}
