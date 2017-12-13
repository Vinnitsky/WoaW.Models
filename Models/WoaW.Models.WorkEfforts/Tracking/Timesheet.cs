using System;
using System.Collections.Generic;
using WoaW.Models.Parties.Relationship;

namespace WoaW.Models.WorkEfforts.Tracking
{
    public class Timesheet
    {
        #region properties
        public string Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ThruDate { get; set; }
        public string Comment { get; set; }

        public PartyRole PartyRole { get; set; }
        public IEnumerable<TimeEntry> Entries {  get;set;}
        #endregion
    }
}
