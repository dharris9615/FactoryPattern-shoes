using System;
namespace FactoryPattern
{
    public class Jordan : IShoes
    {
        public Jordan()
        {
        }

        public void ShoeType()
        {
            Console.WriteLine("Air Jordan Great choice! Its Gotta Be The Shoes!");
        }
    }
}
