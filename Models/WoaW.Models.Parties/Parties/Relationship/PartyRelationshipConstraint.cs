using System;

namespace WoaW.Models.Parties.Relationship
{
    public class PartyRelationshipConstraint
    {
        public string Description { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime ThruDate { get; set; }
        public string Title { get; set; }
        public PartyRelationshipType RelationshipType { get; set; }
        public PartyRoleType Role { get; set; }
        public Func<PartyRelationship, PartyRole, bool> Predicate { get; set; }

        public PartyRelationshipConstraint()
        {
            Id = Guid.NewGuid();
        }
        public PartyRelationshipConstraint(PartyRoleType roleType):this()
        {
            RoleType = roleType;
        }
        public PartyRelationshipConstraint(PartyRelationshipType relationshipType, Func<PartyRelationship, PartyRole, bool> predicate) :this()
        {
            RelationshipType = relationshipType;
            Predicate = predicate;
        }

        public PartyRoleType RoleType { get; set; }
    }
}
