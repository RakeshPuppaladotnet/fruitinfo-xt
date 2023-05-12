using fruit_family_xt_datastore;
using fruit_family_xt_datastore.ViewModels;
using Microsoft.Extensions.Options;

namespace fruit_family_xt_service_query
{
    public class QueryRepo : IFruitQueryRepo
    {
        private readonly IDataStore _datastore;
        private readonly MySettings _options;
        /// <summary>
        /// used to get the all fruit details
        /// </summary>
        /// <param name="dataStore"></param>
        public QueryRepo(IDataStore dataStore, IOptions<MySettings> options)
        {

            _datastore = dataStore;
            _options = options.Value;
        }
        public Task<List<FruitFamilyViewModel>> GetAllFruits(string endPoint)
        {
            try
            {
                string endpoint = _options.GetFruits;
                return _datastore.getFruitInfo(endpoint);
            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// used to get the specific fruit family fruits data 
        /// </summary>
        /// <param name="endPoint"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Task<List<FruitFamilyViewModel>> GetFruitInfo(string endPoint, string fruitFamily)
        {
            try
            {
                string endpoint = _options.Filter + "/" + fruitFamily;
                return _datastore.getFruitInfo(endpoint);
            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}