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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(FlavorsContext db) : base(db)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context = new FlavorsContext();
            return context.Categories.Where(x=>x.Status==true).Count();
        }

        public int CategoryCount()
        {
            using var context=new FlavorsContext();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new FlavorsContext();
            return context.Categories.Where(x => x.Status == false).Count();
        }
    }
}
