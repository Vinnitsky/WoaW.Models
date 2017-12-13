using System;
using System.Collections.Generic;

namespace WoaW.Models.Parties.Relationship
{

    [Serializable]
    public class BreakPartyRelationshipConstraintException : Exception
    {
        public BreakPartyRelationshipConstraintException() { }
        public BreakPartyRelationshipConstraintException(string message) : base(message) { }
        public BreakPartyRelationshipConstraintException(string message, Exception inner) : base(message, inner) { }
        public BreakPartyRelationshipConstraintException(List<PartyRelationshipConstraint> constraines)
        {
            Constraines = constraines;
        }
        protected BreakPartyRelationshipConstraintException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public List<PartyRelationshipConstraint> Constraines { get; set; }
    }
}
