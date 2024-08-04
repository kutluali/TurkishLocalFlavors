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
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        public EfTestimonialDal(FlavorsContext db) : base(db)
        {
        }
    }
}
