using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cripto_info.Models
{
    public class Coin
    {
        public string Id { get; set; }
        [JsonProperty("coin_id")]
        public int CoinId { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        [JsonProperty("market_cap_rank")]
        public int MarketCapRank { get; set; } = 0;
        public string Thumb { get; set; } = string.Empty; 
        public string Small { get; set; } = string.Empty;
        public string Large { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        [JsonProperty("price_btc")]
        public decimal PriceBTC { get; set; } = 0;
        public int Score { get; set; } = 0;

    }
}
