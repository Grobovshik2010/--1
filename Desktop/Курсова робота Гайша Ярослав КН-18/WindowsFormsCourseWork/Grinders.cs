using System;

namespace WindowsFormsCourseWork
{
    [Serializable]
    public class Grinders : PowerTool//Шліфувальні машини
    {
        public Grinders() { }
        public Grinders(PowerTool p) : base(p) { }
        public Grinders(int Number, string Price, string Name, int Day, int Month, int Year, int PowerType, string Country, string photo_file_name = "") : base(Number, Price, Name, Day, Month, Year, PowerType, Country, photo_file_name)
        { }
        public override double DeliveryPrice()//ціна доставки
        {
            return 100;
        }
        public override double ActionPricepercent()//знижка %
        {
            if (Years >= 2) return 5;
            return 0;
        }
    }
}
 