using Company.Core.Entities.Address;
using Company.Manager.Business.Abstract;
using Company.Manager.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.Business.Concrete
{
    public class CountryManager : ICountryService
    {
        #region Injection

        private ICountryDal _countryDal;

        #endregion

        #region ctor

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }
        #endregion

        #region Operations

        public void Add(Country country)
        {
            _countryDal.Add(country);
        }

        public void Delete(Guid countryId)
        {
            _countryDal.Delete(new Country { Id = countryId });
        }

        public List<Country> GetAll()
        {
            return _countryDal.GetList();
        }

        public Country GetById(Guid countryId)
        {
            return _countryDal.Get(c => c.Id == countryId);
        }

        public void Update(Country country)
        {
           var updatedEntity =  _countryDal.Get(c => c.Id == country.Id);
            //var mapper.<country,updatedEntity>
            _countryDal.Update(country);
        }

        #endregion
    }
}
