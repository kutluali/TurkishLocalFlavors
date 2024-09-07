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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(FlavorsContext db) : base(db)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new FlavorsContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public decimal ProductAvgPriceByKebab()
        {
            using var context = new FlavorsContext();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Kebab").Select(z => z.CategoryID).FirstOrDefault())).Average(w => w.Price);
        }

        public int ProductCount()
        {
            using var context = new FlavorsContext();
            return context.Products.Count();
        }

        public int ProductCountByDrink()
        {
            using var context = new FlavorsContext();
            return context.Products.Where(x=>x.CategoryID==(context.Categories.Where(y=>y.CategoryName=="İçecekler").Select(z=>z.CategoryID).FirstOrDefault())).Count();
        }

        public int ProductCountByKebab()
        {
            using var context = new FlavorsContext();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Kebab").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public string ProductNameByMaxPrice()
        {
            using var context = new FlavorsContext();
            return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            using var context = new FlavorsContext();
            return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            using var context =new FlavorsContext();
            return context.Products.Average(x=>x.Price); 

        }

        public decimal ProductPriceByMantı()
        {
            using var context = new FlavorsContext();
            return context.Products.Where(x => x.ProductName == "Steak Burger").Select(y => y.Price).FirstOrDefault();
        }

        public decimal TotalPriceByDrinkCategory()
        {
            using var context = new FlavorsContext();
            int id = context.Categories.Where(x => x.CategoryName == "İçecek").Select(y => y.CategoryID).FirstOrDefault();
            return context.Products.Where(x => x.CategoryID == id).Sum(y => y.Price);
        }

        public decimal TotalPriceBySaladCategory()
        {
            using var context = new FlavorsContext();
            int id = context.Categories.Where(x => x.CategoryName == "Salata").Select(y => y.CategoryID).FirstOrDefault();
            return context.Products.Where(x => x.CategoryID == id).Sum(y => y.Price);
        }
    }
}
