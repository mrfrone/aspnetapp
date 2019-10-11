namespace newtraining.Data.Models
{
    public class Services
    {
        public int ID { get; set; }
        public string serviceName { get; set; }
        public ushort servicePrice { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
