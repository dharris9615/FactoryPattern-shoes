using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello What kind of shoes are you looking for today?");

            string shoeChoice = Console.ReadLine();

            IShoes shoes = ShoeFactory.GetShoes(shoeChoice);
            shoes.ShoeType();
            
        }
    }
}
