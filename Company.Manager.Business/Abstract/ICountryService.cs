using Company.Core.Entities.Address;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.Business.Abstract
{
    /// <summary>
    /// Represents country service.
    /// </summary>
    public interface ICountryService
    {
        /// <summary>
        /// Returns the list of countries from the database.
        /// </summary>
        List<Country> GetAll();

        /// <summary>
        /// Adds the given country object to the database.
        /// </summary>
        void Add(Country country);

        /// <summary>
        /// Updates the given country object in the database.
        /// </summary>
        void Update(Country country);

        /// <summary>
        /// Deletes the database record in the given country id.
        /// </summary>
        void Delete(Guid countryId);

        /// <summary>
        /// Returns the database record in the given country id.
        /// </summary>
        Country GetById(Guid countryId);
    }
}