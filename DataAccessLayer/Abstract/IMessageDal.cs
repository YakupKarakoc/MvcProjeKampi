using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IMessageDal : IRepository<IMessageDal>
	{
		int MessageID { get; set; }

		void Insert(Message message);
		void Delete(Message message);
		void Update(Message message);
		Message Get(Expression<Func<Message, bool>> filter);
		
		List<Message> GetListInbox();
		List<Message> GetListSendbox();
	}
}
