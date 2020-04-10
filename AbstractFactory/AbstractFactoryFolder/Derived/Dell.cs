namespace AbstractFactory.AbstractFactoryFolder
{
    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.Dell.ToString();
        }
    }
}
