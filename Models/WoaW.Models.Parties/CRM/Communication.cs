using System;
using System.Collections.Generic;
using WoaW.Models.Parties.Addresses;
using WoaW.Models.Parties.Relationship;

namespace WoaW.Models.Parties.CRM
{
    /// <summary>
    /// The Communication archetype represents a type of PartyRelationship that captures details of a communication
    /// between two PartyRoles.
    /// 
    /// 
    /// </summary>
    public class Communication : PartyRelationship
    {
        /// <summary>
        /// representing the Address where the Communication originated 
        /// </summary>
        public Address FromAddress { get; set; }
        /// <summary>
        /// representing the Address where the Communication was received
        /// </summary>
        public Address ToAddress { get; set; }
        /// <summary>
        /// The time/date of the Communication— use this if your business initiates the Communication
        /// </summary>
        public DateTime DateSent { get; set; }
        /// <summary>
        /// The time/date of the Communication— use this if the Customer or their CustomerAgent 
        /// initiates the Communication
        /// </summary>
        public DateTime DateReceived { get; set; }
        /// <summary>
        /// The actual content of the Communication— this may be the text of a letter or e-mail or a summary
        /// of a phone conversation
        /// You may be able to hyperlink this field to actual documents such as e-mails and faxes
        /// </summary>
        public string Content { get; set; }
        public PartyRelationship Relationship { get; set; }
        /// <summary>
        /// Each Communication relates a Customer or CustomerAgent to one or more CustomerServiceRepresentatives.
        /// </summary>
        public IEnumerable<PartyRole> CustomerServiceRepresentatives { get; set; }
        public IEnumerable<Action> Actions { get; set; }
        /// <summary>
        /// A summary of the outcome of the Communication— every Communication should have some outcome (this may be something other
        /// than an Action, e.g., agreement that an issue has been resolved)
        /// </summary>
        //public IEnumerable<Outcome> Outcomes { get; set; }

        public Communication(PartyRelationshipType type):base(type)
        {
        }
    }
}
