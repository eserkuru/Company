using Company.Core.Entities.Address;
using Company.Manager.Business.Abstract;
using Company.Manager.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.Business.Concrete
{
    public class CityManager : ICityService
    {
        #region Injection

        private ICityDal _cityDal;

        #endregion

        #region ctor

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        #endregion

        #region Operations

        public void Add(City city)
        {
            _cityDal.Add(city);
        }

        public void Delete(Guid cityId)
        {
            _cityDal.Delete(new City { Id = cityId });
        }

        public List<City> GetAll()
        {
            return _cityDal.GetList();
        }

        public City GetById(Guid cityId)
        {
            return _cityDal.Get(c => c.Id == cityId);
        }

        public void Update(City city)
        {
            _cityDal.Update(city);
        }

        #endregion
    }
}
