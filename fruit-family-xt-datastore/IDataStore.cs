using fruit_family_xt_datastore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_family_xt_datastore
{
    public interface IDataStore
    {
        Task<List<FruitFamilyViewModel>> getFruitInfo(string endPoint);
    }
}
