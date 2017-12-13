using WoaW.Models.Parties.Identifications;

namespace WoaW.Models.Parties.CRM
{
    /// <summary>
    /// The Outcome archetype describes the possible or actual result 
    /// of an Action (the description) and an optional reason for that specific Outcome
    /// </summary>
    public class Outcome
    {
        public PartySignature OutcomeApprovers { get; set; }

    }
}
