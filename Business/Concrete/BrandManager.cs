using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            return new Result(true);
        }

        public IResult Delete(Brand brand)
        {
            return new Result(true);
        }



        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.CarListed);
        }

        public IResult GetById(int id)
        {
            return new Result(true);
        }

        public IResult Update(Brand brand)
        {
            return new Result(true);

        }

       
    }
}
