using System;

namespace InfoSale.Common.Orders
{
    /// <summary>
    /// Class for product in an order
    /// </summary>
    public class OrderProduct : Product
    {
        /// <summary>
        /// Quantity of product
        /// </summary>
        public double Quantity { get; set; } = 0;

        /// <summary>
        /// Gets the total value of the product
        /// </summary>
        public double TotalValue { get => Quantity * UnitPrice; }
    }
}
