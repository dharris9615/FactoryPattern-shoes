using System;
namespace FactoryPattern
{
    public class Nike : IShoes
    {
        public Nike()
        {
        }

        public void ShoeType()
        {
            Console.WriteLine("Awesome choice on nike! Just Do It!" );
        }
    }
}
