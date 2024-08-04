using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkishLocalFlavors.DataAccess.Abstract;
using TurkishLocalFlavors.DataAccess.Concrete;

namespace TurkishLocalFlavors.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly FlavorsContext _db;

        public GenericRepository(FlavorsContext db)
        {
            _db = db;
        }

        public void Add(T entity)
        {
            _db.Add(entity);    
            _db.SaveChanges();

        }

        public void Delete(T entity)
        {
            _db.Remove(entity);
            _db.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _db.Set<T>().Find(id);

        }

        public List<T> GetListAll()
        {
            return _db.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }
    }
}
