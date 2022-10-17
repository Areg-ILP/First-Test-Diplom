namespace First_Test_Diplom.Models.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public string SureName { get; set; }
        public int Age { get; set; }
        public Proffesion Proffesion  { get; set; }

        // for db
        public int SalonId { get; set; }
        public Salon Salon { get; set; }
    }
}
