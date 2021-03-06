///////////////////////////////////////////////////////////
//  Party.cs
//  Implementation of the Class Party
//  Generated by Enterprise Architect
//  Created on:      15-May-2013 9:40:05 PM
//  Original author: Vladimir
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using WoaW.Models.Parties.Addresses;
using WoaW.Models.Parties.Identifications;

namespace WoaW.Models.Parties.Root
{
    public class Party
    {
        #region attributes
        #endregion

        #region prperties
        public PartyIdentifier Id { get; set; }
        public int ActivityStatus { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ThruDate { get; set; }
        public string Version { get; set; }
        public string Title { get; set; }

        public PartySignature Signature { get; set; }
        public IEnumerable<Address> Addresses { get; set; }

        public IEnumerable<RegisteredIdentifier> Identification { get; set; }
        public IEnumerable<PartyAuthentication> Authentications { get; set; }
        #endregion

        #region Constructors
        public Party()
        {
            Id = new PartyIdentifier(Guid.NewGuid());
        }
        #endregion

    }//end Party
}
