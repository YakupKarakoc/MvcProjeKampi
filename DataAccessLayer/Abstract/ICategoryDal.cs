﻿using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface ICategoryDal : IRepository<Category>
	{
		int CategoryID { get; set; }

		List<Category> List();
		void Insert(Category p);
		void Update(Category p);
		void Delete(Category p);
	
	}
}
