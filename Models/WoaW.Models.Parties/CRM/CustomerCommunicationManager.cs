using System;
using System.Collections.Generic;

namespace WoaW.Models.Parties.CRM
{
    public class CustomerCommunicationManager
    {
        private List<CustomerServiceCase> _customerServiceCases { get; set; }
        public Guid Id { get; set; }

        public IEnumerable<CustomerServiceCase> CustomerServiceCases { get; set; }

        public void AddCustomerServiceCases(CustomerServiceCase customerServiceCases)
        {
            (_customerServiceCases as List<CustomerServiceCase>).Add(customerServiceCases);
        }
    }
}
