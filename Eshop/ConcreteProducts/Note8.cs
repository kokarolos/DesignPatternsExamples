public class Note8 : IProduct
{
    public string GetBrand() => Enumerations.Brands.Samsung.ToString();
    public string GetProcessor() => Enumerations.Processors.Exynos990.ToString();
    public string GetRam() => Enumerations.Rams.High.ToString();
    public string GetModel() => Enumerations.Models.Note8.ToString();
    public decimal GetPrice() => 790M;
}
