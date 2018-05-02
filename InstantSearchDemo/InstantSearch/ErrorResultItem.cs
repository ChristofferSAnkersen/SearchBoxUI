using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantSearchDemo.InstantSearch
{
    public class ErrorResultItem : ResultItem
    {
        public string ErrorMessage { get; set; }

        public ErrorResultItem(string group, string errorMessage)
            : base(group)
        {
            this.ErrorMessage = errorMessage;
        }
    }
}
