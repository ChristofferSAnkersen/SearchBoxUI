using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantSearchDemo.InstantSearch
{
    public class ResultItem
    {
        public string Group { get; set; }

        public ResultItem(string group)
        {
            this.Group = group;
        }
    }
}
