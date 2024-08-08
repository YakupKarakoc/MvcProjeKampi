using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	
	public class MessageManager : IMessageService
	{
		Context c = new Context();
		IMessageDal _messageDal;

		public MessageManager(IMessageDal messageDal)
		{
			_messageDal = messageDal;
		}

		public void MessageAdd(Message message)
		{
			_messageDal.Insert(message);
		}

		public Message GetByID(int id)
		{
			return (Message)_messageDal.Get(x => x.MessageID == id);
		}


		public void MessageDelete(Message message)
		{
			_messageDal.Delete(message);
		}

		public void MessageUpdate(Message message)
		{
			_messageDal.Update(message);
		}

		public List<Message> GetListInbox(string p)
		{
			return c.Messages.Where(x => x.ReceiverMail == p).ToList();

		}

		public List<Message> GetListSendbox(string p)
		{
			return c.Messages.Where(x => x.SenderMail == p).ToList();
		}
	}
}
