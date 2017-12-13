///////////////////////////////////////////////////////////
//  IdentificationDocument.cs
//  Implementation of the Class IdentificationDocument
//  Generated by Enterprise Architect
//  Created on:      15-May-2013 9:40:04 PM
//  Original author: Vladimir
///////////////////////////////////////////////////////////

using System.Collections.Generic;
namespace WoaW.Models.Parties.Identifications
{
    public class IdentificationDocument
    {
        public System.Guid Id { get; set; }
        virtual public IEnumerable<PageScan> PageScan { get; set; }
        virtual public PartyIdentifier Identification { get; set; }

        public IdentificationDocument()
        {
        }

    }//end IdentificationDocument

}//end namespace Identification