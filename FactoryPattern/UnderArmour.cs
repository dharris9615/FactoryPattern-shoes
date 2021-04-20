using System;
namespace FactoryPattern
{
    public class UnderArmour : IShoes
    {
        public UnderArmour()
        {
        }

        public void ShoeType()
        {
            Console.WriteLine("Under Armour! Not a bad choice! The Only Way Is Through" );
        }
    }
}
