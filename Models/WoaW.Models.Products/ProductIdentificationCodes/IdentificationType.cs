namespace WoaW.Models.Products.ProductIdentificationCodes
{
    public sealed class IdentificationType
    {
        public static readonly IdentificationType ManufacturedId = new IdentificationType() { Id = 1, Name = "ManufacturedId" };
        public static readonly IdentificationType UPCA = new IdentificationType() { Id = 2, Name = "UPCA" };
        public static readonly IdentificationType SKU = new IdentificationType() { Id = 3, Name = "SKU" };
        public static readonly IdentificationType ISBN = new IdentificationType() { Id = 4, Name = "ISBN", Description= "International Standard Book Number" };
        public static readonly IdentificationType UPCE = new IdentificationType() { Id = 5, Name = "UPCE", Description= "Universal Product Code—European" };
        public static readonly IdentificationType OtherId = new IdentificationType() { Id = 6, Name = "OtherId" };

        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
