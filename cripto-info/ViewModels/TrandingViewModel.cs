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
        public string BaseURL = "https://api.coingecko.com/api/v3";
        //public NotifyTaskCompletion<ServerStatus> Status { get; private set; }
        public NotifyTaskCompletion<List<CoinItem>> CoinItems { get; private set; }


        public TrandingViewModel()
        {
            //Status = new NotifyTaskCompletion<ServerStatus>(ApiServiceClient.GetServerStatusAsync(string.Concat(BaseURL + "/ping")));
            CoinItems = new NotifyTaskCompletion<List<CoinItem>>(ApiServiceClient.GetTrendingCoinsAsync(string.Concat(BaseURL + "/search/trending")));
        }
    }
}
