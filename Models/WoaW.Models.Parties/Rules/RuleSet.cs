///////////////////////////////////////////////////////////
//  RuleSet.cs
//  Implementation of the Class RuleSet
//  Generated by Enterprise Architect
//  Created on:      15-May-2013 9:40:06 PM
//  Original author: Vladimir
///////////////////////////////////////////////////////////

using System;
using System.Linq;
using WoaW.Models.Parties.Root;

namespace WoaW.Models.Rules
{
    public class RuleSet
    {
        public string AtributeTitle { get; set; }
        public string AtributeValue { get; set; }
        public string Description { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime ThruDate { get; set; }
        public string Title { get; set; }
        public Func<Party, bool> Predicate { get; set; }

        public RuleSet()
        {
            Id = Guid.NewGuid();
        }
        //TODO: use dynamic linq
        public RuleSet( Func<Party, bool> predicate):this()
        {
            Predicate = predicate;
        }

    }//end RuleSet
}
