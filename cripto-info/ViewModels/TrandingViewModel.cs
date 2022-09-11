using cripto_info.Models;
using cripto_info.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cripto_info.ViewModels
{
    public class TrandingViewModel
    {
        public NotifyTaskCompletion<List<CoinItem>> CoinItems { get; private set; }


        public TrandingViewModel(string url)
        {
            CoinItems = new NotifyTaskCompletion<List<CoinItem>>(ApiServiceClient.GetTrendingCoinsAsync(url));
        }
    }
}
