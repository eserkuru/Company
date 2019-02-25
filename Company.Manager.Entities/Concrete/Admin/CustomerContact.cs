using Company.Manager.Entities.Abstract;

namespace Company.Manager.Entities.Concrete.Admin
{
    /// <summary>
    /// Represents an customer contact
    /// </summary>
    public class CustomerContact : Contact
    {

        #region Properties

        /// Comes from the base class
        /// PhoneNumberType  : PhoneNumberType
        /// string           : PhoneNumber
        /// string           : EMail

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public virtual Customer Customer { get; set; }

        #endregion
    }
}
