using InstantSearchDemo.InstantSearch;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InstantSearchDemo.ViewModels
{
    public class MainWindowViewModel
    {

        List<ProductsResultItem> _allProductResultItems;
        List<HelpResultItem> _allHelpResultItems;

        string _searchText;
        public string SearchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                _searchText = value;
                SearchResults.Clear();
                foreach(ProductsResultItem item in _allProductResultItems) {
                    if(item.ProductName.ToLower().Contains(_searchText.ToLower())) {
                        SearchResults.Add(item);
                    }
                }
                foreach (HelpResultItem item in _allHelpResultItems)
                {
                    if (item.Title.ToLower().Contains(_searchText.ToLower()))
                    {
                        SearchResults.Add(item);
                    }
                }
            }
        }

        public ObservableCollection<ResultItem> SearchResults { get; set; }

        ResultItem _selectedResult;
        public ResultItem SelectedResult
        {
            get
            {
                return _selectedResult;
            }
            set
            {
                _selectedResult = value;
                // Handle selection here
            }
        }

        public MainWindowViewModel()
        {
            SearchResults = new ObservableCollection<ResultItem>();



            _allProductResultItems = new List<ProductsResultItem>();
            _allProductResultItems.Add(new ProductsResultItem("Produkter", "Hættetrøje", "Astralis Hættetrøje"));
            _allProductResultItems.Add(new ProductsResultItem("Produkter", "Kasket", "Liquid Kasket"));
            _allProductResultItems.Add(new ProductsResultItem("Produkter", "iPhone Cover", "iPhone cover m. OG Logo"));

            _allHelpResultItems = new List<HelpResultItem>();
            _allHelpResultItems.Add(new HelpResultItem("Help Topics", "Add customer", "To add a customer ..."));
            _allHelpResultItems.Add(new HelpResultItem("Help Topics", "Delete customer", "To delete a customer ..."));

            SearchText = "";
        }

    }
}
