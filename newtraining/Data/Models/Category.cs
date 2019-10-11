using System.Collections.Generic;

namespace newtraining.Data.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string categoryName{ get; set; }
        public List<Services> services { get; set; }
    }
}
