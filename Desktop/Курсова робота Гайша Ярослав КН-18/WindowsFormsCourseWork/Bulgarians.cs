using System;

namespace WindowsFormsCourseWork
{
    [Serializable]
    public class Bulgarians : PowerTool 
    {
        public Bulgarians() { }
        public Bulgarians(PowerTool p) : base(p) { }
        public Bulgarians(int Number, string Price, string Name, int Day, int Month, int Year, int PowerType, string Country, string photo_file_name = "") : base(Number, Price, Name, Day, Month, Year, PowerType, Country, photo_file_name)
        { }
        public override double DeliveryPrice()//ціна доставки
        {
            return 35;
        }
        public override double ActionPricepercent()//знижка %
        {
            if (Years >= 5) return 5;
            if (Years >= 4) return 4;
            if (Years >= 3) return 3;
            if (Years >= 2) return 2;
            if (Years >= 1) return 1;
            return 0;
        }
    }
}
 
