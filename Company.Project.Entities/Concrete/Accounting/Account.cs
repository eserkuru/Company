using Company.Core.Entities;
using Company.Project.Entities.Concrete.Admin;

namespace Company.Project.Entities.Concrete.Accounting
{
    /// <summary>
    /// Represents an account
    /// </summary>
    public class Account : BaseEntity
    {

        #region Properties

        /// <summary>
        /// Gets or sets the trade number
        /// </summary>
        public string TradeName { get; set; }

        /// <summary>
        /// Gets or sets the tax number
        /// </summary>
        public string TaxNumber { get; set; }

        /// <summary>
        /// Gets or sets the tax office
        /// </summary>
        public string TaxOffice { get; set; }

        /// <summary>
        /// Gets or sets the tax office
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Gets or sets the tax office
        /// </summary>
        public decimal InTotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the tax office
        /// </summary>
        public decimal TotalAmountOut { get; set; }

        #endregion

        #region Navigation properties

        /// <summary>
        /// Gets or sets the branch
        /// </summary>
        public virtual Branch Branch { get; set; }

        /// <summary>
        /// Gets or sets the account type
        /// </summary>
        public virtual AccountType AccountType { get; set; }

        /// <summary>
        /// Gets or sets the account type
        /// </summary>
        public virtual Currency Currency { get; set; }

        #endregion

    }
}
