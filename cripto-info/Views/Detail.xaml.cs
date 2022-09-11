using cripto_info.Models;
using cripto_info.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Detail.xaml
    /// </summary>
    public partial class Detail : Page
    {
        public Detail()
        {
            InitializeComponent();        
        }

        public Detail(string id)
        {
            InitializeComponent();
            DataContext = new DetailViewModel($"https://api.coingecko.com/api/v3/coins/{id}?localization=false&tickers=true&market_data=true&community_data=false&developer_data=false&sparkline=true");
            
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Ticker ticker = listMarkets.SelectedItem as Ticker;

            if (ticker.TradeURL != null)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = ticker.TradeURL,
                    UseShellExecute = true
                });
            }

        }
    }

}
