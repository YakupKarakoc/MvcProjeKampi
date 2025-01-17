﻿using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IContentService
	{
		//List<Content> Nurcan(int id);

		List<Content> GetListByHeadingID(int id);
		List<Content> GetList();
		List<Content> GetListByWriter(int id);
		void ContentAdd(Content content);
		Content GetByID(int id);

		void ContentDelete(Content content);
		void ContentUpdate(Content content);
	}
}
