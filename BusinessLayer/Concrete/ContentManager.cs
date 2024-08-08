
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BusinessLayer.Concrete
{
	public class ContentManager : IContentService
	{
		IContentDal _contentDal;

		public ContentManager(IContentDal contentDal)
		{
			_contentDal = contentDal;
		}

		public void ContentAdd(Content content)
		{
			_contentDal.Insert(content);
		}

		public object GetListByHeadingID()
		{
			throw new NotImplementedException();
		}

		public void ContentDelete(Content content)
		{
			throw new NotImplementedException();
		}

		public void ContentUpdate(Content content)
		{
			throw new NotImplementedException();
		}

		public Content GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Content> GetList()
		{
			return _contentDal.List();
		}

		public List<Content> GetListByHeadingID(int id)
		{
			Context c = new Context();
			return c.Contents.Where(x => x.HeadingID == id).ToList();
		}

		public List<Content> GetListByWriter(int id)
		{
			Context c = new Context();
			return c.Contents.Where(x => x.WriterID == id).ToList();
		
		}

		

		//public List<Content> Nurcan(int id)
		//{
		//	return _contentDal.Nurcan(id);
		//}
	}
}