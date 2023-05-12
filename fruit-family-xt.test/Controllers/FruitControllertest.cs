using fruit_family_xt.Controllers;
using fruit_family_xt_datastore.ViewModels;
using fruit_family_xt_service_query;
using Microsoft.Extensions.Options;
using Moq;

namespace fruit_family_xt.test.Controllers
{
    [TestClass]
    public class FruitControllertest
    {
        /// <summary>
        /// used to test the getall fruits information
        /// </summary>
        [TestMethod]
        public async void GetAllFruitsTest()
        {
            List<FruitFamilyViewModel> fruitFamilyViewModels = new List<FruitFamilyViewModel>();
            var mockObject = new Mock<IFruitQueryRepo>();
            var mockOptions = new Mock<IOptions<MySettings>>();
            mockObject.Setup(p => p.GetAllFruits("All")).ReturnsAsync(fruitFamilyViewModels);
            FruitController fruitController = new FruitController(mockObject.Object, mockOptions.Object);
            var response = await fruitController.GetAllFruits();
            Assert.IsNotNull(response);

        }
        /// <summary>
        /// used to test the specific fruitfamily info
        /// </summary>
        [TestMethod]
        public async void GetFruitInfoTest()
        {
            FruitFamilyViewModel fruitFamilyViewModels = new FruitFamilyViewModel()
            {
                Name = "",
                Genus = "",
                Family = "Rosaceae",
                Id = 0,
                Nutritions = null



            };
            var mockObject = new Mock<IFruitQueryRepo>();
            var mockOptions = new Mock<IOptions<MySettings>>();
            mockObject.Setup(p => p.GetFruitInfo("family", fruitFamilyViewModels.Family)).ReturnsAsync(It.IsAny<List<FruitFamilyViewModel>>());
            FruitController fruitController = new FruitController(mockObject.Object,mockOptions.Object);
            var response = await fruitController.GetFruitInfo(fruitFamilyViewModels);
            Assert.IsNotNull(response);

        }
    }
}