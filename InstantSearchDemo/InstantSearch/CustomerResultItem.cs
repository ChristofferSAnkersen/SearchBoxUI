using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantSearchDemo.InstantSearch
{
    public class ProductsResultItem : ResultItem
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        //public string ContactMail { get; set; }

        public ProductsResultItem(string group, string productName, string productDescription)
            : base(group)
        {
            this.ProductName = productName;
            this.ProductDescription = productDescription;
        }
    }
}
