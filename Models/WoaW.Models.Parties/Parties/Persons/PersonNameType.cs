///////////////////////////////////////////////////////////
//  PersonNameType.cs
//  Implementation of the Class PersonNameType
//  Generated by Enterprise Architect
//  Created on:      15-May-2013 9:40:06 PM
//  Original author: Vladimir
///////////////////////////////////////////////////////////

using System.Collections.Generic;
namespace WoaW.Models.Parties.Persons
{
    public class PersonNameType
    {
        public System.Guid Id { get; set; }
        public string Description { get; set; }
        virtual public PersonNameCode Code { get; set; }
        virtual public ICollection<PersonNameOption> Options { get; set; }

        public PersonNameType()
        {
            //this.Options = new List<PersonNameOption>();
        }

    }//end PersonNameType

}//end namespace Persons