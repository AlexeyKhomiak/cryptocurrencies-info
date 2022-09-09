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
        //public static async Task<ServerStatus> GetServerStatusAsync(string url)
        //{
        //    ServerStatus serverStatus = null;
        //    using (HttpClient client = new HttpClient())
        //    {
        //        var data = await client.GetAsync(url);
        //        string jsonResponse = await data.Content.ReadAsStringAsync();
        //        if (jsonResponse != null)
        //        {
        //            serverStatus = JsonConvert.DeserializeObject<ServerStatus>(jsonResponse);
        //        }
        //        return serverStatus;
        //    }
        //}

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
    }
}
