using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class PurchaseRepository: RepositoryBase<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
    }
}
