using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{

	
	public class WriterRepository : IWriterDal
	{
		Context c = new Context();
		DbSet<Writer> _object;

		public void Delete(Writer writer)
		{
			throw new NotImplementedException();
		}

		public void Delete(IWriterDal p)
		{
			throw new NotImplementedException();
		}

		public Writer Get(Expression<Func<Writer, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public IWriterDal Get(Expression<Func<IWriterDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Insert(Writer writer)
		{
			throw new NotImplementedException();
		}

		public void Insert(IWriterDal p)
		{
			throw new NotImplementedException();
		}

		public List<Writer> List()
		{
			throw new NotImplementedException();
		}

		public List<IWriterDal> List(Expression<Func<IWriterDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Update(Writer writer)
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