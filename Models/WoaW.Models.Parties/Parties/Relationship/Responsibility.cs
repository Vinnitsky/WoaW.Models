using System.Collections.Generic;

namespace WoaW.Models.Parties.Relationship
{
    public class Responsibility
    {
        public System.Guid Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        IEnumerable<string> RequirementsForResponsibility { get; set; }
    }
}
