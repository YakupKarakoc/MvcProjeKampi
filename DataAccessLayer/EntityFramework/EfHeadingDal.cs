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
	public class EfHeadingDal : GenericRepository<Heading>, IHeadingDal
	{
		public int HeadingID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int WriterID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void Delete(IHeadingDal p)
		{
			throw new NotImplementedException();
		}

		public IHeadingDal Get(Expression<Func<IHeadingDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Insert(IHeadingDal p)
		{
			throw new NotImplementedException();
		}

		public List<IHeadingDal> List(Expression<Func<IHeadingDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Update(IHeadingDal p)
		{
			throw new NotImplementedException();
		}

		//List<IHeadingDal> IRepository<IHeadingDal>.List()
		//{
		//	throw new NotImplementedException();
		//}
	}
}