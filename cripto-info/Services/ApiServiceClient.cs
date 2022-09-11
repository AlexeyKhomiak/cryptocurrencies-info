using cripto_info.Models;
using cripto_info.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Trending = cripto_info.Models.Trending;

namespace cripto_info.Services
{
    public class ApiServiceClient
    {
        public static async Task<List<CoinItem>> GetTrendingCoinsAsync(string url)
        {
            List<CoinItem> coinItems = new List<CoinItem>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    if (responseBody != null)
                    {
                        coinItems = JsonConvert.DeserializeObject<Trending>(responseBody).coins;
                    }
                    foreach (var item in coinItems)
                    {
                        item.Item.Score += 1;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                throw new Exception(e.Message);
            }
            return coinItems;
        }

        public static async Task<CoinDetail> GetCoinDetailAsync(string url)
        {
            CoinDetail coinDetail = null;
            string responseBody = "";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    responseBody = await response.Content.ReadAsStringAsync();
                    if (responseBody != null)
                    {
                        coinDetail = JsonConvert.DeserializeObject<CoinDetail>(responseBody);

                        if (coinDetail.Symbol != null)
                        {
                            coinDetail.Symbol = coinDetail.Symbol.ToUpper();
                        }
                        
                    }
                    
                }
            }
            catch (HttpRequestException e)
            {
                throw new Exception(e.Message);
            }
            return coinDetail;
        }
    }
}
