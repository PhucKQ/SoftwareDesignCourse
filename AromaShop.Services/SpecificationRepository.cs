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
    public class SpecificationRepository : Repository<Specification>, ISpecificationRepository
    {
        private readonly ApplicationDbContext _db;

        public SpecificationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Specification obj)
        {
            _db.Specifications.Update(obj);
        }
    }
}
