using System;
using System.Collections.Generic;
using WoaW.Models.Rules;

namespace WoaW.Models.Parties.Relationship
{

    [Serializable]
    public class BreakPartyRulesException : Exception
    {
        public BreakPartyRulesException() { }
        public BreakPartyRulesException(string message) : base(message) { }
        public BreakPartyRulesException(string message, Exception inner) : base(message, inner) { }
        public BreakPartyRulesException(List<RuleSet> rules)
        {
            Rules = rules;
        }
        protected BreakPartyRulesException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public List<RuleSet> Rules { get; set; }
    }
}
