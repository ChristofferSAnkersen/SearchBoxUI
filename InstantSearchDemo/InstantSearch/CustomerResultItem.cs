using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantSearchDemo.InstantSearch
{
    public class CustomerResultItem : ResultItem
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactMail { get; set; }

        public CustomerResultItem(string group, string companyName, string contactName, string contactMail)
            : base(group)
        {
            this.CompanyName = companyName;
            this.ContactName = contactName;
            this.ContactMail = contactMail;
        }
    }
}
