using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkishLocalFlavors.Business.Abstract;
using TurkishLocalFlavors.DataAccess.Abstract;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavors.Business.Concrete
{
    public class MenuTableManager : IMenuTableService
    {
        private readonly IMenuTableDal _menuTableDal;
        public MenuTableManager(IMenuTableDal menuTableDal)
        {
            _menuTableDal = menuTableDal;
        }
        public void TAdd(MenuTable entity)
        {
            _menuTableDal.Add(entity);
        }

        public void TDelete(MenuTable entity)
        {
            _menuTableDal.Delete(entity);
        }

        public MenuTable TGetByID(int id)
        {
            return _menuTableDal.GetByID(id);

        }

        public List<MenuTable> TGetListAll()
        {
            return _menuTableDal.GetListAll();
        }

        public void TUpdate(MenuTable entity)
        {
            _menuTableDal.Update(entity);
        }
    }
}
