using System;

namespace WindowsFormsCourseWork
{
    [Serializable]
    public class Drills : PowerTool//Дрилі
    {
        public Drills() { }
        public Drills(PowerTool p) : base(p) { }
        public Drills(int Number, string Price, string Name, int Day, int Month, int Year, int PowerType, string Country, string photo_file_name = "") : base(Number, Price, Name, Day, Month, Year, PowerType, Country, photo_file_name)
        { }
        public override double DeliveryPrice()//ціна доставки
        {
            return 30;
        }
        public override double ActionPricepercent()//знижка %
        {
            if (Years >= 5) return 12; 
            if (Years >= 4) return 10;
            if (Years >= 3) return 8;
            if (Years >= 2) return 6;
            if (Years >= 1) return 4;
            return 0;
        }
    }
}

