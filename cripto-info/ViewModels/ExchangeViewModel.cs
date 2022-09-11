﻿using cripto_info.Models;
using cripto_info.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cripto_info.ViewModels
{
    internal class ExchangeViewModel
    {
        public NotifyTaskCompletion<List<CoinSearch>> SearchResult { get; private set; }

        public ExchangeViewModel(string url)
        {
            SearchResult = new NotifyTaskCompletion<List<CoinSearch>>(ApiServiceClient.GetSearchResultAsync(url));
        }
    }
}
