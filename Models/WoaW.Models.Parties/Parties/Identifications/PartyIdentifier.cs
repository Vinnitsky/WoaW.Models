///////////////////////////////////////////////////////////
//  Identification.cs
//  Implementation of the Class PartyIdentifier
//  Generated by Enterprise Architect
//  Created on:      15-May-2013 9:40:04 PM
//  Original author: Vladimir
///////////////////////////////////////////////////////////

using System;

namespace WoaW.Models.Parties.Identifications
{
    /// <summary>
    /// The PartyIdentifier archetype represents a unique identifier for a Party.
    /// Using database terminology, the PartyIdentifier acts as a primary key for accessing the Party information.
    /// </summary>
    public class PartyIdentifier : UniqueIdentifier
    {
        public PartyIdentifier(Guid id):base(id)
        {
        }

    }//end Identification

}//end namespace Identification