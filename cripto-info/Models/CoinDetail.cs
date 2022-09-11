using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cripto_info.Models
{
    public class CoinDetail
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public Image Image { get; set; } = new Image { Large = "https://img.freepik.com/premium-vector/gold-coin-isolated-transparent-background_227128-52.jpg?w=2000" };
        [JsonProperty("market_cap_rank")]
        public string MarketCapRank { get; set; } = string.Empty;
        [JsonProperty("market_data")]
        public Market MarketData { get; set; } = new Market();
        public List<Ticker> Tickers { get; set; } = new List<Ticker>();

    }
}
