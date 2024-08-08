using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{

	public class EfContactDal : GenericRepository<Contact>, IContactDal
	{
		Context c = new Context();
		public int HeadingID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void Delete(IContactDal p)
		{
			throw new NotImplementedException();
		}

		public IContactDal Get(Expression<Func<IContactDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Contact> GetListByHeadingID(int id)
		{
			return c.Contacts.Where(x => x.ContactID == id).ToList();
		}

		public void Insert(IContactDal p)
		{
			throw new NotImplementedException();
		}

		public List<Contact> List(Func<Contact, bool> predicate)
		{
			throw new NotImplementedException();
		}

		public List<IContactDal> List(Expression<Func<IContactDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Update(IContactDal p)
		{
			throw new NotImplementedException();
		}

		//Content IContactDal.Get(Expression<Func<Contact, bool>> filter)
		//{
		//	throw new NotImplementedException();
		//}

		List<IContactDal> IRepository<IContactDal>.List()
		{
			throw new NotImplementedException();
		}
	}
}
