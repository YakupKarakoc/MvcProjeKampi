using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IHeadingDal : IRepository<Heading>
	{
		int HeadingID { get; set; }
		int WriterID { get; set; }
	

		void Insert(Heading heading);
		void Delete(Heading heading);
		void Update(Heading heading);
		Heading Get(Expression<Func<Heading, bool>> filter);
		List<Heading> List();
	}
}
