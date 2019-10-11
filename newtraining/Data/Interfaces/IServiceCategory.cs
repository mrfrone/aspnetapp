using System.Collections.Generic;
using newtraining.Data.Models;

namespace newtraining.Data.Interfaces
{
    public interface IServiceCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
