using System;

namespace WindowsFormsCourseWork
{
    [Serializable]
    public class Saw : PowerTool//Пилки
    {
        public Saw() { }
        public Saw(PowerTool p) : base(p) { }
        public Saw(int Number, string Price, string Name, int Day, int Month, int Year, int PowerType, string Country, string photo_file_name = "") : base(Number, Price, Name, Day, Month, Year, PowerType, Country, photo_file_name)
        { }
        public override double DeliveryPrice()//ціна доставки
        {
            if (V < 0.03) return 50;
            else if (V < 0.06) return 100;
            else if (V < 0.12) return 200;
            else return 400;
        }
        public override double ActionPricepercent()//знижка %
        {
            if (Years >= 5) return 8;
            if (Years >= 4) return 7;
            if (Years >= 3) return 6;
            if (Years >= 2) return 5;
            if (Years >= 1) return 2;
            return 0;
        }
    }
}

 