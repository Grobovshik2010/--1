using System;

namespace WindowsFormsCourseWork
{
    [Serializable]
    public class Perforators : PowerTool 
    {
        public Perforators() { }
        public Perforators(PowerTool p) : base(p) { }
        public Perforators(int Number, string Price, string Name, int Day, int Month, int Year, int PowerType, string Country, string photo_file_name = "") : base(Number, Price, Name, Day, Month, Year, PowerType, Country, photo_file_name)
        { }
        public override double DeliveryPrice()//ціна доставки
        {
            if(V<0.03) return 50;
            else if(V<0.06)return 100;
            return 200;
        }
        public override double ActionPricepercent()//знижка %
        {
            if (Years >= 5) return 13; 
            if (Years >= 4) return 11;
            if (Years >= 3) return 9;
            if (Years >= 2) return 7;
            if (Years >= 1) return 5;
            return 0;
        }
    }
}