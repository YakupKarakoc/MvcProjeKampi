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
	public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
	{
		public int CategoryID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public void Delete(ICategoryDal p)
		{
			throw new NotImplementedException();
		}

		public ICategoryDal Get(Expression<Func<ICategoryDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Insert(ICategoryDal p)
		{
			throw new NotImplementedException();
		}

		public List<ICategoryDal> List(Expression<Func<ICategoryDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Update(ICategoryDal p)
		{
			throw new NotImplementedException();
		}

		//List<ICategoryDal> IRepository<ICategoryDal>.List()
		//{
		//	throw new NotImplementedException();
		//}
	}
}
