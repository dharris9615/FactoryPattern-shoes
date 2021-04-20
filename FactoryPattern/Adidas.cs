using System;
namespace FactoryPattern
{
    public class Adidas : IShoes
    {
        public Adidas()
        {
        }

        public void ShoeType()
        {
            Console.WriteLine("Great choice on Adidas! Impossible Is Nothing!");
        }
    }
}
