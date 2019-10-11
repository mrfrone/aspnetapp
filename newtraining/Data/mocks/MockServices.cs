using System.Collections.Generic;
using System.Linq;
using newtraining.Data.Interfaces;
using newtraining.Data.Models;

namespace newtraining.Data.mocks
{
    public class MockServices : IAllServices
    {
        private readonly IServiceCategory _categoryService = new MockCategory();
        public IEnumerable<Services> AllServices => new List<Services>
                {
                    new Services
                    {
                        serviceName = "Забор крови",
                        servicePrice = 150,
                        Category = _categoryService.AllCategories.First()
                    },
                    new Services
                    {
                        serviceName = "Анализ",
                        servicePrice = 1000,
                        Category = _categoryService.AllCategories.Last()
                    },
                    new Services
                    {
                        serviceName = "ЭКГ",
                        servicePrice = 800,
                        Category = _categoryService.AllCategories.First()
                    },
                    new Services
                    {
                        serviceName = "МРТ",
                        servicePrice = 1500,
                        Category = _categoryService.AllCategories.Last()
                    }
                };
    }
}
