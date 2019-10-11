using System.Collections.Generic;
using newtraining.Data.Models;

namespace newtraining.Data.Interfaces
{
    public interface IAllServices
    {
        IEnumerable<Services> AllServices { get; }
    }
}
