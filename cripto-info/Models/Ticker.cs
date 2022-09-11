using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cripto_info.Models
{
    public class Ticker
    {
        public string Base { get; set; } = string.Empty;
        public string Target { get; set; } = string.Empty;
        public Exchange Market { get; set; } = new Exchange();
        public decimal Volume { get; set; } = decimal.Zero;
        [JsonProperty("trade_url")]
        public string TradeURL { get; set; } = string.Empty;
        [JsonProperty("last")]
        public decimal Price { get; set; } = decimal.Zero;
    }
}
