using System;

namespace WoaW.Models.Parties.Identifications
{
    public class RegisteredIdentifier
    {
        public System.Guid Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
