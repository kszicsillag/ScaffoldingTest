using System.ComponentModel.DataAnnotations;

namespace Library1.Models
{
    public class Car
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int ManufacturerID { get; set; }
        public Manufacturer Manufacturer { get; set; }
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
    public class Manufacturer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
