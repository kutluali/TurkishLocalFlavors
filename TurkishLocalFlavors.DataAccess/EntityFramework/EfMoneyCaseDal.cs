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
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        public EfMoneyCaseDal(FlavorsContext db) : base(db)
        {
        }

        public decimal TotalMoneyCaseAmount()
        {
            using var context = new FlavorsContext();
            return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
        }
    }
}
