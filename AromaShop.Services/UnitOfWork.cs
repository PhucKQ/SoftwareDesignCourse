using AromaShop.Data;
using AromaShop.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromaShop.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IProductRepository Product { get; private set; }

        public ISpecificationRepository Specification { get; private set; }
        public IProductSpecificationRepository ProductSpecification { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Product = new ProductRepository(_db);
            Specification = new SpecificationRepository(_db);
            ProductSpecification = new ProductSpecificationRepository(_db);
        }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
