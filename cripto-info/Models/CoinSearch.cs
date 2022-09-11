using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cripto_info.Models
{
    public class CoinSearch
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        [JsonProperty("api_symbol")]
        public string ApiSymbol { get; set; } = string.Empty;
        [JsonProperty("market_cap_rank")]
        public string MarketCapRank { get; set; } = string.Empty;
        public string Thumb { get; set; } = string.Empty;
        public string Large { get; set; } = string.Empty;
    }
}
