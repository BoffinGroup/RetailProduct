using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IPurchaseRepository: IRepositoryBase<Purchase>
    {
        Task<IEnumerable<Purchase>> GetAllPurchasesAsync();
        Task<Purchase> GetPurchaseByIdAsync(int id);
        Task<Purchase> GetPurchaseWithDetailsAsync(int id);
        void CreatePurchase(Purchase purchase);
        void UpdatePurchase(Purchase purchase);
        void DeletePurchase(Purchase purchase);
    }
}
