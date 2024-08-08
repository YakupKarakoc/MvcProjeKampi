using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Abstract
{
	public interface IContentDal : IRepository<IContentDal>
	{
		

		int HeadingID { get; set; }
		Content Get(Expression<Func<Content, bool>> filter);
		List<Content> List();
		List<Content> List(Func<Content, bool> predicate);
		void Insert(Content content);
		void Delete(Content content);
		void Update(Content content);
		List<Content> GetListByHeadingID(int id);


	}
}
