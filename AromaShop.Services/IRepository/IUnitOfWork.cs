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
        IBrandRepository Brand { get; }
        IColorRepository Color { get; }
        ICategoryRepository Category { get; }
        ISpecificationRepository Specification { get; }
        IProductSpecificationRepository ProductSpecification { get; }
        IProductColorRepository ProductColor { get; }
        IUserRepository User { get; }
        IShoppingCartRepository ShoppingCart { get; }

        IOrderDetailRepository OrderDetail { get; }
        IOrderHeaderRepository OrderHeader { get; }
        void Save();
    }
}
