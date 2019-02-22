using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Manager.Entities.Enums
{
    /// <summary>
    /// Represents a customer type, determines the taxpayer
    /// </summary>
    public enum CustomerType
    {
        /// <summary>
        /// Orders are created with the customer's name and surname
        /// </summary>
        Person = 10,

        /// <summary>
        /// Orders created to the individual
        /// </summary>
        Company = 20
    }
}
