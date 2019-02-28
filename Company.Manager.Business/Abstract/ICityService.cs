using Company.Core.Entities.Address;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.Business.Abstract
{
    /// <summary>
    /// Represents city service.
    /// </summary>
    public interface ICityService
    {
        /// <summary>
        /// Returns the list of cities from the database.
        /// </summary>
        List<City> GetAll();

        /// <summary>
        /// Adds the given city object to the database.
        /// </summary>
        void Add(City city);

        /// <summary>
        /// Updates the given city object in the database.
        /// </summary>
        void Update(City city);

        /// <summary>
        /// Deletes the database record in the given city id.
        /// </summary>
        void Delete(Guid cityId);

        /// <summary>
        /// Returns the database record in the given city id.
        /// </summary>
        City GetById(Guid cityId);
    }
}
