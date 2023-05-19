using AromaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Services.IRepository
{
    public interface IProductColorRepository : IRepository<ProductColor>
    {
        void Update(ProductColor obj);
    }
}
