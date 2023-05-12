using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_family_xt_datastore.ViewModels
{
    public class FruitFamilyViewModel
    {

        public string Name { get; set; }

        public int Id { get; set; }

        public string Family { get; set; }

        public string Order { get; set; } 

        public string Genus { get; set; }


        public NutritionsViewModel Nutritions { get; set; }
    }
}
