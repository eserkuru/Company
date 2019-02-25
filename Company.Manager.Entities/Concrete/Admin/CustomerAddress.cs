using Company.Manager.Entities.Abstract;

namespace Company.Manager.Entities.Concrete.Admin
{
    /// <summary>
    /// Represents a customer address
    /// </summary>
    public class CustomerAddress: Address
    {
        #region Properties

        /// Comes from the base class
        /// string  : Description
        /// string  : PostalCode
        /// Country : Country
        /// City    : City
        /// Town    : Town

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public virtual Customer Customer { get; set; }

        #endregion

    }
}
