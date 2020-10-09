using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IStockRepository Stock { get; }
        IPurchaseRepository Purchase { get; }
        Task SaveAsync();
    }
}
