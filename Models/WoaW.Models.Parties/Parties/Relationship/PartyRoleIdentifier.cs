using System;
using WoaW.Models.Parties.Identifications;

namespace WoaW.Models.Parties.Relationship
{
    public class PartyRoleIdentifier: UniqueIdentifier
    {
        public PartyRoleIdentifier(Guid id): base(id.ToString("N"))
        {
        }
        public PartyRoleIdentifier(string id): base(id)
        {
        }
    }
}
