namespace Lab05LibZavd
{
    public class Telephone
    {
        public required string Model { get; set; }
        public required string Color { get; set; }
        public required string OperatSystem { get; set; }
        public int Ram { get; set; }
        public int Cores { get; set; }
        public int Memory { get; set; }
        public int Battery { get; set; }
        public bool HasNfc { get; set; }
        public bool HasSpeedCharge { get; set; }
    }
}
