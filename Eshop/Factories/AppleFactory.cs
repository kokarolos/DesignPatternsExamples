public class AppleFactory : SmarthPhoneFactory
{
    public override IProduct CreateSmartPhone(string smartphone)
    {
        switch (smartphone)
        {
            case "IphoneX":
                return new IPhoneX();
            default:
                return null;
        }
    }
}
