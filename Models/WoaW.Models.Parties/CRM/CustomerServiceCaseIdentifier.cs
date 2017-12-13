using System;
using WoaW.Models.Parties.Identifications;

namespace WoaW.Models.Parties.CRM
{
    /// <summary>
    /// The CustomerServiceCaseIdentifier archetype represents a unique identifier for a CustomerServiceCase.
    /// </summary>
    public class CustomerServiceCaseIdentifier : UniqueIdentifier
    {
        public CustomerServiceCaseIdentifier(Guid id):base(id)
        {

        }
        public static CustomerServiceCase GetCustomerServiceCase() { throw new NotImplementedException(); }
    }
}
