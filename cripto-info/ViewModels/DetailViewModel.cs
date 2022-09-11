using cripto_info.Models;
using cripto_info.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cripto_info.ViewModels
{
    internal class DetailViewModel
    {
        public NotifyTaskCompletion<CoinDetail> CoinDetail { get; private set; }

        public DetailViewModel(string url)
        {
            CoinDetail = new NotifyTaskCompletion<CoinDetail>(ApiServiceClient.GetCoinDetailAsync(url));
        }
    }
}
