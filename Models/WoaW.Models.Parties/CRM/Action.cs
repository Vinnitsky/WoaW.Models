using System;
using System.Collections.Generic;
using WoaW.Models.Parties.CRM;
using WoaW.Models.Parties.Identifications;

namespace WoaW.Model.Parties.CRM
{
    /// <summary>
    /// The Action archetype represents a description of something that can happen.
    /// </summary>
    public class Action
    {
        public Guid Id { get; set; }
        /// <summary>
        /// A short description of the Action—this should focus on what the Action is trying to achieve
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// An optional reason for the Action
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// This is the status of the Action—typically this will be one of "pending", "open", or "closed"
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// The time/date on which the Action was started
        /// </summary>
        public DateTime Start{ get; set; }
        /// <summary>
        /// The time/date on which the Action was concluded
        /// </summary>
        public DateTime End{ get; set; }

        /// <summary>
        /// Every Action may optionally have zero to many possibleOutcomes that describe the range 
        /// of possible results that the Action can generate. This is useful when you know in advance 
        /// all the possibleOutcomes for a given Action.
        /// For example, a specific Communication such as "Ordered goods not received" may generate
        /// the Action "Check despatch status of goods", and this may have one of two 
        /// possibleOutcomes — "Goods despatched" or "Goods not despatched". Either of these 
        /// possibleOutcomes may generate further Communications and Actions.
        /// </summary>
        public IEnumerable<Outcome> PossibleOutcomes { get; set; }
        /// <summary>
        /// Every Action must have one or more actualOutcomes, otherwise there is no point in performing
        /// the Action. (The description of this Outcome may be "Pending" when first created.)
        /// </summary>
        public IEnumerable<Outcome> ActualOutcomes { get; set; }
        /// <summary>
        /// If necessary for auditing purposes, each actualOutcome may be signed off by zero or more 
        /// outcomeApprovers as represented by their PartySignatures.
        /// </summary>
        public PartySignature ActionApprovers { get; set; }

        public PartySignature ActionInitiators { get; set; }
    }
}
