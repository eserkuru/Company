using Company.Core.Entities;
using System.Text;

namespace Company.Project.Entities.Concrete.ClientManagment
{
    /// <summary>
    /// Represents an organisation
    /// </summary>
    public class Organisation : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Current Name identifier
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Current ShortName identifier
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the Current LogoURL identifier
        /// </summary>
        public string LogoURL { get; set; }

        /// <summary>
        /// Gets or sets the Current TradeName identifier
        /// </summary>
        public string TradeName { get; set; }

        /// <summary>
        /// Gets or sets the Current TradeNumber identifier
        /// </summary>
        public string TradeNumber { get; set; }

        /// <summary>
        /// Gets or sets the Current TaxNumber identifier
        /// </summary>
        public string TaxNumber { get; set; }

        /// <summary>
        /// Gets or sets the Current TaxOffice identifier
        /// </summary>
        public string TaxOffice { get; set; }

        /// <summary>
        /// Gets or sets the Current CRSNumber identifier
        /// </summary>
        public string CRSNumber { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the Current Client identifier
        /// </summary>
        public virtual Client Client { get; set; }

        #endregion
    }
}
