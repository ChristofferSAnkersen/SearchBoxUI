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

        List<CustomerResultItem> _allCustomerResultItems;
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
                foreach(CustomerResultItem item in _allCustomerResultItems) {
                    if(item.CompanyName.ToLower().Contains(_searchText.ToLower())) {
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

            _allCustomerResultItems = new List<CustomerResultItem>();
            _allCustomerResultItems.Add(new CustomerResultItem("Customers", "ABC Corp", "Helga Smith", "helga.smith@abccorp.com"));
            _allCustomerResultItems.Add(new CustomerResultItem("Customers", "We Love Plumbing", "Joe Scott", "scott@weloveplumbing.com"));
            _allCustomerResultItems.Add(new CustomerResultItem("Customers", "Boing Search", "Bill G. Ates", "chief@boing.com"));

            _allHelpResultItems = new List<HelpResultItem>();
            _allHelpResultItems.Add(new HelpResultItem("Help Topics", "Add customer", "To add a customer ..."));
            _allHelpResultItems.Add(new HelpResultItem("Help Topics", "Delete customer", "To delete a customer ..."));

            SearchText = "";
        }

    }
}
