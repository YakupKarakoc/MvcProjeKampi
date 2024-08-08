using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfMessageDal : GenericRepository<Message>, IMessageDal
	{
		Context c = new Context();

		public int MessageID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void Delete(IMessageDal p)
		{
			throw new NotImplementedException();
		}

		public IMessageDal Get(Expression<Func<IMessageDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Message> GetListInbox()
		{
			throw new NotImplementedException();
		}

		public List<Message> GetListSendbox()
		{
			throw new NotImplementedException();
		}

		public void Insert(IMessageDal p)
		{
			throw new NotImplementedException();
		}

		public List<IMessageDal> List(Expression<Func<IMessageDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Update(IMessageDal p)
		{
			throw new NotImplementedException();
		}

		List<IMessageDal> IRepository<IMessageDal>.List()
		{
			throw new NotImplementedException();
		}
	}
}
