using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavors.Business.Abstract
{
    public interface IBasketService: IGenericService<Basket>
    {
        List<Basket> TGetBasketByMenuTableNumber(int id);


    }
}
