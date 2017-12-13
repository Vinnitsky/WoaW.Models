using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoaW.Models.Parties.Identifications;
using WoaW.Models.Parties.Relationship;

namespace WoaW.Models.Parties.Parties.Relationship
{
    /// <summary>
    ///  in certain circumstances you will need to take a snapshot of a small subset 
    ///  of this information for a specific purpose. You can handle this using the 
    ///  PartySummary archetype 
    /// </summary>
    public class PartySummary
    {
        #region properties
        public PartyIdentifier PartyIdentification { get; set; }
        public PartyRole Role { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        #endregion
        public PartySummary()
        {

        }
    }
}
