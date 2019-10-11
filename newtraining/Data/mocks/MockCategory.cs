using System.Collections.Generic;
using newtraining.Data.Interfaces;
using newtraining.Data.Models;

namespace newtraining.Data.mocks
{
    public class MockCategory : IServiceCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category>
                {
                    new Category 
                    { 
                        categoryName = "Одно" 
                    },
                    new Category 
                    { 
                        categoryName = "Другое" 
                    }
                };
            }
        }
    }
}
