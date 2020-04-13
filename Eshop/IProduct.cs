namespace Eshop
{
    public interface IProduct
    {
        int Id { get; set; }
        string Model { get; set; }
        decimal GetPrice();
    }
}
