using System;
namespace FactoryPattern
{
    static class ShoeFactory
    {
        public static IShoes GetShoes(string shoetype)
        {
            switch (shoetype.ToLower())
            {
                case "nike":
                case "nikes":
                    return new Nike();
                case "adidas":
                    return new Adidas();
                case "under armour":
                    return new UnderArmour();
                case "jordans":
                case "jordan":
                    return new Jordan();
                default:
                    return new Barefoot();
            }
        }
    
    }
}
