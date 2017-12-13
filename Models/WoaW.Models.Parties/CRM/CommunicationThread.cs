using System;
using System.Collections.Generic;
using WoaW.Models.Parties.Identifications;

namespace WoaW.Models.Parties.CRM
{
    /// <summary>
    /// The CommunicationThread archetype represents a sequence of Communications about a particular topic.
    /// </summary>
    public class CommunicationThread
    {
        private List<Communication> _communications;
        public Guid Id { get; set; }
        /// <summary>
        /// indicates the topic of the thread 
        /// </summary>
        public string TopicName { get; set; }
        public string BriefDescription { get; set; }
        /// <summary>
        /// The start of a CommunicationThread is usually the date of the first Communication
        /// </summary>
        public DateTime Start { get; set; }
        /// <summary>
        /// The end of the thread may be the date of the last Communication or the date a decision
        /// was made to close the thread (a PartySignature can optionally be captured in this instance
        /// to identify the communicationThreadTerminator).
        /// </summary>
        public DateTime End { get; set; }

        public PartySignature CommunicationThreadTerminator { get; set; }

        public IEnumerable<Communication> Communications { get; private set; }

        public void AddCommunication(Communication communication)
        {
            (_communications as List<Communication>).Add(communication);
        }
    }
}
