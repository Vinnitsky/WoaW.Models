using WoaW.Models.Parties.Relationship;

namespace WoaW.Models.Parties.CRM
{
    /// <summary>
    /// The CommunicationRouting archetype is a special type of Communication that represents a handover 
    /// between CustomerServiceRepresentatives
    /// </summary>
    public class CommunicationRouting : Communication
    {
        public CommunicationRouting(PartyRelationshipType type):base(type)
        {

        }
        public bool IsEscalation { get; set; }
        /// <summary>
        /// indicate whether the CommunicationRouting represents an escalation of the Communication
        /// to a higher authority.
        /// </summary>
        public string Reason { get; set; }
    }
}
