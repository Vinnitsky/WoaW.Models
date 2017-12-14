namespace WoaW.Models.Products.ProductIdentificationCodes
{
    public sealed class GoodIdentification
    {
        #region properties
        public string ID { get; set; }
        public Product Product { get; set; }
        public IdentificationType IdentificationType { get; set; }
        #endregion
    }
}
