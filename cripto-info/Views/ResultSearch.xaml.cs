using cripto_info.Models;
using cripto_info.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cripto_info.Views
{
    /// <summary>
    /// Interaction logic for ResultSearch.xaml
    /// </summary>
    public partial class ResultSearch : Page
    {
        public ResultSearch()
        {
            InitializeComponent();
        }
        
        public ResultSearch(string textSearch)
        {
            InitializeComponent();
            DataContext = new SearchViewModel($"https://api.coingecko.com/api/v3/search?query={textSearch}");
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CoinSearch coinSearch = listSearchResult.SelectedItem as CoinSearch;

            if (coinSearch.Id != null)
            {
                NavigationService.Navigate(new Detail(coinSearch.Id));
            }
        }
    }
}
