using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IContactDal : IRepository<IContactDal>
	{
		int HeadingID { get; set; }
		Contact Get(Expression<Func<Contact, bool>> filter);
		List<Contact> List();
		List<Contact> List(Func<Contact, bool> predicate);
		void Insert(Contact contact);
		void Delete(Contact contact);
		void Update(Contact contact);
		List<Contact> GetListByHeadingID(int id);

	}
}
