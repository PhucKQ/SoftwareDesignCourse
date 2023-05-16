using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Services.IRepository
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        ISpecificationRepository Specification { get; }
        IProductSpecificationRepository ProductSpecification { get; }
        void Save();
    }
}
