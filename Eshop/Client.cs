public class Client
{
    private IProduct _product;
    private SmarthPhoneFactory _factory;
    public Client(string factory)
    {
        if(factory=="Apple")
        {
            _factory = new AppleFactory();
            _product = _factory.CreateSmartPhone("IphoneX");
        }
        else
        {
            _factory = new SamsungFactory();
            _product = _factory.CreateSmartPhone("Note8");
        }
    }

    public string GetProductDescirption()=> $"Product Created is {_product.GetBrand()} " +
        $"{_product.GetModel()} with {_product.GetProcessor()} and ram {_product.GetRam()}";
}