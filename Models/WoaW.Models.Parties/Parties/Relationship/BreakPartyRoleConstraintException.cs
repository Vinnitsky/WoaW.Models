using System;
using System.Collections.Generic;

namespace WoaW.Models.Parties.Relationship
{

    [Serializable]
    public class BreakPartyRoleConstraintException : Exception
    {
        public BreakPartyRoleConstraintException() { }
        public BreakPartyRoleConstraintException(string message) : base(message) { }
        public BreakPartyRoleConstraintException(string message, Exception inner) : base(message, inner) { }
        public BreakPartyRoleConstraintException(List<PartyRoleConstraint> constraines)
        {
            Constraines = constraines;
        }
        protected BreakPartyRoleConstraintException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public List<PartyRoleConstraint> Constraines { get; set; }
    }
}
