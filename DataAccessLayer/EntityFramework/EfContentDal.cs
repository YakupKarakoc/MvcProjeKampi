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
	public class EfContentDal : GenericRepository<Content>, IContentDal
	{
		Context c = new Context();
		public int HeadingID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void Delete(IContentDal p)
		{
			throw new NotImplementedException();
		}

		public IContentDal Get(Expression<Func<IContentDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Content> GetListByHeadingID(int id)
		{
			return c.Contents.Where(x => x.HeadingID == id ).ToList();
		}

	

		public void Insert(IContentDal p)
		{
			throw new NotImplementedException();
		}

		public List<Content> List(Func<Content, bool> predicate)
		{
			return c.Contents.Where(x => x.WriterID == 4).ToList();
		}

		public List<IContentDal> List(Expression<Func<IContentDal, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Update(IContentDal p)
		{
			throw new NotImplementedException();
		}

		List<IContentDal> IRepository<IContentDal>.List()
		{
			throw new NotImplementedException();
		}
	}
}










//using DataAccessLayer.Abstract;
//using DataAccessLayer.Concrete;
//using DataAccessLayer.Concrete.Repositories;
//using EntityLayer.Concreate;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccessLayer.EntityFramework
//{
//	public class EfContentDal : GenericRepository<Content>, IContentDal
//	{
//		public int HeadingID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//		public void Delete(IContentDal p)
//		{
//			throw new NotImplementedException();
//		}

//		public IContentDal Get(Expression<Func<IContentDal, bool>> filter)
//		{
//			throw new NotImplementedException();
//		}

//		public List<Content> GetListByHeadingID(int id)
//		{
//			throw new NotImplementedException();
//		}

//		public void Insert(IContentDal p)
//		{
//			throw new NotImplementedException();
//		}

//		public List<IContentDal> List(Expression<Func<IContentDal, bool>> filter)
//		{
//			throw new NotImplementedException();
//		}

//		public List<Content> List(Func<Content, bool> predicate)
//		{
//			throw new NotImplementedException();
//		}

//		public void Update(IContentDal p)
//		{
//			throw new NotImplementedException();
//		}

//		List<IContentDal> IRepository<IContentDal>.List()
//		{
//			throw new NotImplementedException();
//		}
//	}
//}