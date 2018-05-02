using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantSearchDemo.InstantSearch
{
    public class HelpResultItem : ResultItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public HelpResultItem(string group, string title, string description)
            : base(group)
        {
            this.Title = title;
            this.Description = description;
        }
    }
}
