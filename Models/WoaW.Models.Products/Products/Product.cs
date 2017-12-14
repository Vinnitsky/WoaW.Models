using System;

namespace WoaW.Models.Products
{
    public abstract class Product
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public DateTime IntoductionDate { get; set; }
        public DateTime SalesDiscontinuationDate { get; set; }
        public DateTime SupportDiscontinuationDate { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }

    }
}
