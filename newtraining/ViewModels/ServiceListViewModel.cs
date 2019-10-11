using System.Collections.Generic;
using newtraining.Data.Models;

namespace newtraining.ViewModels
{
    public class ServiceListViewModel
    {
        public IEnumerable<Services> AllServices { get; set; }
        public string currCategory { get; set; }
    }
}
