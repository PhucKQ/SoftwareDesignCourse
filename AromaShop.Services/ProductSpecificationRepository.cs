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
    public class ProductSpecificationRepository : Repository<ProductSpecification>, IProductSpecificationRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductSpecificationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ProductSpecification obj)
        {
            _db.ProductSpecifications.Update(obj);
        }
    }
}
