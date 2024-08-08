﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        //Context c = new Context();
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public Heading GetByID(int id)
        { 
            return _headingDal.Get(x => x.HeadingID == id);
        }

        public List<Heading> GetList()
        {
            return _headingDal.List();
        }

		public List<Heading> GetListByWriter(int id)
		{
            return _headingDal.List(x => x.WriterID == id);
		}


		public void HeadingAdd(Heading heading)
        {
            _headingDal.Insert(heading); 
        }

        public void HeadingDelete(Heading heading)
        {
            if (heading.HeadingStatus == true)
            {
                heading.HeadingStatus = false;
                _headingDal.Update(heading);
            }
            else if (heading.HeadingStatus == false)
            {
                heading.HeadingStatus = true;
                _headingDal.Update(heading);
            }

        }

        public void HeadingUpdate(Heading heading)
        {
            _headingDal.Update(heading); 
        }
    }
}
