using System.Collections.Generic;

namespace First_Test_Diplom.Models.Entities
{
    public class Salon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
