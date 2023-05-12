using fruit_family_xt_datastore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_family_xt_service_query
{
    public interface IFruitQueryRepo
    {
        Task<List<FruitFamilyViewModel>> GetAllFruits(string endPoint);

        Task<List<FruitFamilyViewModel>> GetFruitInfo(string endPoint, string filter);
    }
}

