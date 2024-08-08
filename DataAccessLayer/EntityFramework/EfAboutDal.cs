using DataAccessLayer.Abstract;
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
	public class EfAboutDal : GenericRepository<About>, IAboutDal
	{
		public void Delete(About p)
		{
			throw new NotImplementedException();
		}

		public About Get(Expression<Func<About, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Insert(About p)
		{
			throw new NotImplementedException();
		}

		public List<About> List(Expression<Func<About, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Update(About p)
		{
			throw new NotImplementedException();
		}

		//List<IAboutDal> IRepository<IAboutDal>.List()
		//{
		//	throw new NotImplementedException();
		//}
	}
}
