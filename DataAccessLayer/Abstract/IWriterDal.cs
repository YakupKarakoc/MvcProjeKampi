using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IWriterDal : IRepository<IWriterDal>
	{
		Writer Get(Expression<Func<Writer, bool>> filter);
		List<Writer> List();
		void Insert(Writer writer);
		void Delete(Writer writer);
		void Update(Writer writer);
	}
}
