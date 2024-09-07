using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkishLocalFlavors.DataAccess.Abstract;
using TurkishLocalFlavors.DataAccess.Concrete;
using TurkishLocalFlavors.DataAccess.Repository;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavors.DataAccess.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(FlavorsContext db) : base(db)
        {
        }

        public List<Basket> GetBasketByMenuTableNumber(int id)
        {
            using var context = new FlavorsContext();
            var values=context.Baskets.Where(x=>x.MenuTableID ==id).Include(y=>y.Product).ToList();
            return values;
        }
    }
}
