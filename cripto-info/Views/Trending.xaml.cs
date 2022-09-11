﻿using cripto_info.Models;
using cripto_info.ViewModels;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for Trending.xaml
    /// </summary>
    public partial class Trending : Page
    {
        public Trending()
        {
            InitializeComponent();
            DataContext = new TrandingViewModel("https://api.coingecko.com/api/v3/search/trending");
        }

        private void TextBlock_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            CoinItem coin  = listTopCoin.SelectedItem as CoinItem;

            NavigationService.Navigate(new Detail(coin.Item.Id));
        }
    }
}
