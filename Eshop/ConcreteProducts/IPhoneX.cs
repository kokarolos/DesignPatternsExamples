public class IPhoneX : IProduct
{
    public string GetBrand() => Enumerations.Brands.Apple.ToString();
    public string GetProcessor() => Enumerations.Processors.A13.ToString();
    public string GetRam() => Enumerations.Rams.Medium.ToString();
    public string GetModel() => Enumerations.Models.IphoneX.ToString();
    public decimal GetPrice() => 1390M;

}
