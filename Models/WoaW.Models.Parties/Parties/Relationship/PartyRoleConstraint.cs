using System;
using WoaW.Models.Parties.Root;

namespace WoaW.Models.Parties.Relationship
{
    /// <summary>
    /// The PartyRoleConstraint archetype specifies the typeOfParty that is allowed
    /// to play a PartyRole of a specific PartyRoleType
    /// 
    /// One or more PartyRoleConstraints are associated with each PartyRoleType
    /// </summary>
    /// <remarks>
    /// Which types of Parties (e.g., People, Companies) can play which PartyRoles?
    /// Which PartyRoles can participate in which PartyRelationships?
    /// 
    /// A good way to capture this information is simply to add constraints to 
    /// the PartyRoleType and the PartyRelationshipType,
    /// </remarks>
    /// <example>
    /// The Husband PartyRole must always be played by a Party of type Person.
    /// The Wife PartyRole must always be played by a Party of type Person.
    /// In this view of Marriage, the Marriage PartyRelationship must always be between a Husband and a Wife.
    /// </example>
    public class PartyRoleConstraint
    {
        public PartyRoleConstraint(Type type)
        {
            PartyType = type;
        }
        public Type PartyType { get; set; }
        public bool CanPlayRole(Party party) { throw new NotImplementedException(); }
    }
}
