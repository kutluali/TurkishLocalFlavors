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
	public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
	{
		public EfNotificationDal(FlavorsContext db) : base(db)
		{
		}

		public List<Notification> GetAllNotificationByFalse()
		{
			using var context = new FlavorsContext();
			return context.Notifications.Where(x => x.Status == false).ToList();
		}

		public int NotificationCountByStatusFalse()
		{
			using var context = new FlavorsContext();
			return context.Notifications.Where(x => x.Status == false).Count();
		}

		public void NotificationStatusChangeToFalse(int id)
		{
			using var context = new FlavorsContext();
			var value = context.Notifications.Find(id);
			value.Status = false;
			context.SaveChanges();
		}

		public void NotificationStatusChangeToTrue(int id)
		{
			using var context = new FlavorsContext();
			var value = context.Notifications.Find(id);
			value.Status = true;
			context.SaveChanges();
		}
	}
}
