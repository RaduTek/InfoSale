using System;

namespace InfoSale.Common.Orders
{
    /// <summary>
    /// Base class for an order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Order unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date and time of order creation
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Order status
        /// </summary>
        public OrderStatus Status { get; set; }


        /// <summary>
        /// Class constructor
        /// </summary>
        public Order()
        {
            DateTime = DateTime.Now;
        }
    }
}
