using System;
namespace FactoryPattern
{
    public class Barefoot : IShoes
    {
        public Barefoot()
        {
        }

        public void ShoeType()
        {
            Console.WriteLine("Sorry! You don't get new shoes today!");
        }
    }
}
