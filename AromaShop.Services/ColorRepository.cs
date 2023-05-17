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
    public class ColorRepository : Repository<Color>, IColorRepository
    {
        private readonly ApplicationDbContext _db;

        public ColorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Color obj)
        {
            _db.Colors.Update(obj);
        }
    }
}
