using AromaShop.Data;
using AromaShop.Models;
using AromaShop.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Services
{
    public class ProductColorRepository : Repository<ProductColor>, IProductColorRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductColorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ProductColor obj)
        {
            _db.ProductColors.Update(obj);
        }
    }
}
