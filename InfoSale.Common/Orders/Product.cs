using System;

namespace InfoSale.Common.Orders
{
    /// <summary>
    /// Base class for a product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product short name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Product description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Product asset tag (barcode)
        /// </summary>
        public string IdTag { get; set; }

        /// <summary>
        /// Price per unit
        /// </summary>
        public double UnitPrice { get; set; }

        /// <summary>
        /// Unit type
        /// </summary>
        public string UnitType { get; set; }

        /// <summary>
        /// Product weight in kilograms
        /// </summary>
        public double Weight { get; set; }
    }
}
