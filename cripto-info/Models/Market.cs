using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cripto_info.Models
{
    public class Market
    {
        [JsonProperty("current_price")]
        public Price CurrentPrice { get; set; } = new Price();
        [JsonProperty("market_cap")]
        public MarketCap MarketCap { get; set; } = new MarketCap();
        [JsonProperty("total_volume")]
        public Volume TotalVolume { get; set; } = new Volume();
        [JsonProperty("price_change_percentage_24h")]
        public decimal PriceChangePercentage24h { get; set; } = decimal.Zero;
        public string ColorPrice
        {
            get { return PriceChangePercentage24h<0?"Red":"Green"; }
            set { }
            
        }

    }
}
