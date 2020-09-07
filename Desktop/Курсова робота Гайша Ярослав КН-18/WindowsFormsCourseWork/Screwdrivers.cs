using System;

namespace WindowsFormsCourseWork
{
    [Serializable]
    public class Screwdrivers: PowerTool//Шоруповерт
    {
        public Screwdrivers(){}
        public Screwdrivers(PowerTool p) :base(p){}
        public Screwdrivers(int Number, string Price, string Name, int Day, int Month, int Year, int PowerType, string Country, string photo_file_name = "") : base( Number,  Price,  Name,  Day,  Month,  Year,  PowerType,  Country,  photo_file_name)
        {}
        public override double DeliveryPrice()//цена доставки
        {
            return 20;
        }
        public override double ActionPricepercent()//скидка % в зависимость от давности товара и типа товара
        {
            if (Years >= 5) return 10;// 10%
            if (Years >= 4) return 8;
            if (Years >= 3) return 6;
            if (Years >= 2) return 4;
            if (Years >= 1) return 2;
            return 0;
        }
    }
}
