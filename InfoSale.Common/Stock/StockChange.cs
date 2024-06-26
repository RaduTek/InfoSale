using InfoSale.Common.Orders;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoSale.Common.Stock
{
    /// <summary>
    /// Base class for a stock change entry
    /// </summary>
    public class StockChange
    {
        /// <summary>
        /// ID of affected product
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Change value of stock
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Reference to customer order
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Customer order
        /// </summary>
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        /// <summary>
        /// Reference to supply chain
        /// </summary>
        public int SupplyId { get; set; }

        /// <summary>
        /// Date and time of entry creation
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        public StockChange()
        {
            DateTime = DateTime.Now;
        }
    }
}
