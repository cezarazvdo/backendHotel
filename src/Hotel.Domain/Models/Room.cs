namespace Hotel.Domain.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public int Capacity { get; set; }
        public bool Suite { get; set; }
        public bool Available { get; set; }
        public int DoubleBads { get; set; }
        public int SingleBads { get; set; }
    }
}
