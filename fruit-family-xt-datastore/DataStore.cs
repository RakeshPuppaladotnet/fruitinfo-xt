using fruit_family_xt_datastore.ViewModels;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http;

namespace fruit_family_xt_datastore
{
    public class DataStore : IDataStore
    {
        private readonly MySettings _options;
        private readonly IHttpClientFactory _httpClientFactory;

        public DataStore(IOptions<MySettings> options, IHttpClientFactory httpClientFactory)
        {
            _options = options.Value;
            _httpClientFactory = httpClientFactory;
        }
        /// <summary>
        /// common method used to get the fruit information based on end point request and filter
        /// </summary>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        public async Task<List<FruitFamilyViewModel>> getFruitInfo(string filter)
        {
            try
            {
                var fruitList = new List<FruitFamilyViewModel>();
                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(_options.BaseAddress);
                string result = await client.GetStringAsync(filter);
                fruitList = JsonConvert.DeserializeObject<List<FruitFamilyViewModel>>(result);
                return fruitList;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}