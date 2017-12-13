using System;
using System.Collections.Generic;
using WoaW.Models.Parties.Relationship;

namespace WoaW.Models.Parties.CRM
{
    /// <summary>
    /// The CustomerServiceCase archetype represents a collection of all Communications 
    /// about a specific topic related to a specific Customer.
    /// 
    /// Each CustomerServiceCase has its own unique CustomerServiceCaseIdentifier and 
    /// is managed by a caseManager who is a CustomerServiceRepresentative (another type of PartyRole).
    /// </summary>
    public class CustomerServiceCase
    {
        #region attributes
        private List<CommunicationThread> _communicationThreads;
        #endregion

        #region properties
        public CustomerServiceCaseIdentifier Id { get; set; }
        /// <summary>
        /// The title of the case—this should summarize the nature of the case, e.g., "Complaint about call out service"
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// A short description of the case, e.g., "The customer complained about the response time on DD:MM:YYYY"
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The PartyRoleIdentifier of the PartyRole that raised the case—this is usually
        /// the PartyRoleIdentifier of a Customer
        /// </summary>
        public PartyRoleIdentifier RaisedBy { get; set; }
        /// <summary>
        /// The time/date on which the case began—usually, that of the first Communication in the case
        /// </summary>
        public DateTime Start { get; set; }
        /// <summary>
        /// The time/date on which the case ended—usually, that of the last Communication in the case
        /// or when a decision was made to close the case
        /// </summary>
        public DateTime End { get; set; }
        /// <summary>
        /// This is true if the case is still open and false if the case has been closed
        /// </summary>
        public bool IsOpen { get; set; }
        /// <summary>
        /// This is an indication of the importance of the case from the perspective of the business, e.g., 
        /// cases may be prioritized as "low", "medium", or "high" priority
        /// </summary>
        public int Priority { get; set; }
        public IEnumerable<CommunicationThread> CommunicationThreads { get; private set; }
        #endregion

        #region constructors
        public CustomerServiceCase()
        {
            Id = new CustomerServiceCaseIdentifier(Guid.NewGuid());
            _communicationThreads = new List<CommunicationThread>();
        }
        public CustomerServiceCase(CustomerServiceCaseIdentifier id):this()
        {
            Id = id;
        }
        #endregion

        #region public API
        public void AddThread(CommunicationThread thread)
        {
            (_communicationThreads as List<CommunicationThread>).Add(thread);
        }
        #endregion
    }
}
