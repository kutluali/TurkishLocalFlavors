using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkishLocalFlavors.Business.Abstract;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavors.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderService _orderService;

        public OrderManager(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public void TAdd(Order entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
