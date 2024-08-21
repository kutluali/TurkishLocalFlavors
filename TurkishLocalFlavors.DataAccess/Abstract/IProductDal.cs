using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavors.DataAccess.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();

        int ProductCount();
        int ProductCountByKebab();
        int ProductCountByDrink();
        decimal ProductPriceAvg();
        string ProductNameByMaxPrice();
        string ProductNameByMinPrice();

    }
}
