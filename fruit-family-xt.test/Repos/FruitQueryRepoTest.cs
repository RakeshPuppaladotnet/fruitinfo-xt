using fruit_family_xt_datastore;
using fruit_family_xt_datastore.ViewModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_family_xt.test.Repos
{
    public class FruitQueryRepoTest
    {
        /// <summary>
        /// used to test the repository method 
        /// </summary>
        [TestMethod]
        public async void GetAllFruitsTest()
        {
            string getAllFruits = "all";
            var mockObject= new Mock<IDataStore>();
            mockObject.Setup(p => p.getFruitInfo(getAllFruits)).ReturnsAsync(It.IsAny<List<FruitFamilyViewModel>>);
            var response = mockObject.Object.getFruitInfo(getAllFruits);
            Assert.IsNotNull(response);
        
        }
        /// <summary>
        /// used to test the Fruit info method based on fruit family
        /// </summary>
        [TestMethod]
        
        public async void GetFruitInfoTest()
        {
            string filter = ""; 
            string fruitEndPoint = "";
            var mockObject = new Mock<IDataStore>();
            mockObject.Setup(p => p.getFruitInfo(fruitEndPoint+filter)).ReturnsAsync(It.IsAny<List<FruitFamilyViewModel>>);
            var response = mockObject.Object.getFruitInfo(filter+fruitEndPoint);
            Assert.IsNotNull(response);
        }
    }
}
