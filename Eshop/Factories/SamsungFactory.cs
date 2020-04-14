using Eshop.ConcreteProducts;

public class SamsungFactory : SmarthPhoneFactory
{
    public override IProduct CreateSmartPhone(string smartphone)
    {
        switch (smartphone)
        {
            case "Note8":
                return new Note8();
            default:
                return new Note10();
        }
    }
}
