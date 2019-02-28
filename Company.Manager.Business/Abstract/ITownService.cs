using Company.Core.Entities.Address;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.Business.Abstract
{
    /// <summary>
    /// Represents town service.
    /// </summary>
    public interface ITownService
    {
        /// <summary>
        /// Returns the list of towns from the database.
        /// </summary>
        List<Town> GetAll();

        /// <summary>
        /// Adds the given town object to the database.
        /// </summary>
        void Add(Town town);

        /// <summary>
        /// Updates the given town object in the database.
        /// </summary>
        void Update(Town town);

        /// <summary>
        /// Deletes the database record in the given town id.
        /// </summary>
        void Delete(Guid townId);

        /// <summary>
        /// Returns the database record in the given town id.
        /// </summary>
        Town GetById(Guid townId);
    }
}
