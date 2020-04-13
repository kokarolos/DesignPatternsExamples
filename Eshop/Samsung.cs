namespace Eshop
{
    public class Samsung : ISmartPhone
    {
        public string Model { get; set; }
        public int Ram { get; set; }
        public int Id { get; set; }
        public string Catergory { get; set; }

        public decimal GetPrice()
        {
            return 600.26M;
        }
    }
}
