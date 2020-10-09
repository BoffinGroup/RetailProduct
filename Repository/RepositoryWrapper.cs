using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;


namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repositoryContext;
        private IStockRepository _stockRepository;
        private IPurchaseRepository _purchaseRepository;
        public IStockRepository Stock {
            get{ 
                if(_stockRepository == null)
                {
                    _stockRepository = new StockRepository(_repositoryContext);
                }
                return _stockRepository;
            }
        }

        public IPurchaseRepository Purchase {
            get { 

                if(_purchaseRepository == null)
                {
                    _purchaseRepository = new PurchaseRepository(_repositoryContext);
                }
                return _purchaseRepository;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public async Task SaveAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }
    }
}
