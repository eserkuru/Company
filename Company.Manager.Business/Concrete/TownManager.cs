using Company.Core.Entities.Address;
using Company.Manager.Business.Abstract;
using Company.Manager.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.Business.Concrete
{
    public class TownManager : ITownService
    {
        #region Injection

        private ITownDal _townDal;

        #endregion

        #region ctor

        public TownManager(ITownDal townDal)
        {
            _townDal = townDal;
        }
        #endregion

        #region Operations

        public void Add(Town town)
        {
            _townDal.Add(town);
        }

        public void Delete(Guid townId)
        {
            _townDal.Delete(new Town { Id = townId });
        }

        public List<Town> GetAll()
        {
            return _townDal.GetList();
        }

        public Town GetById(Guid townId)
        {
            return _townDal.Get(c => c.Id == townId);
        }

        public void Update(Town town)
        {
            _townDal.Update(town);
        }

        #endregion
    }
}
