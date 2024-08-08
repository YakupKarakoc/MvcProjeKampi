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
	public class EfWriterDal : GenericRepository<Writer>, IWriterDal
	{
		public void Delete(IWriterDal p)
		{
			throw new NotImplementedException();
		}

		public IWriterDal Get(Expression<Func<IWriterDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Insert(IWriterDal p)
		{
			throw new NotImplementedException();
		}

		public List<IWriterDal> List(Expression<Func<IWriterDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Update(IWriterDal p)
		{
			throw new NotImplementedException();
		}

		List<IWriterDal> IRepository<IWriterDal>.List()
		{
			throw new NotImplementedException();
		}
	}
}
