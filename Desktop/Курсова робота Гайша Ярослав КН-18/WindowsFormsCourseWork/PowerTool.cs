using System;
using System.Collections.Generic;

    namespace WindowsFormsCourseWork
{
    [Serializable]
    public class PowerTool
    {
    
        public int Number { get; set; }
        public string Price { get; set; }
        public string Name { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public int PowerType { get; set; }
        public string photo_file_name { get; set; }
        public int Years //Давність товару, років
        {
           get
            {
                  DateTime date1 = new DateTime(Year, Month, Day);
                  DateTime sysdate = DateTime.Now;
                  var date3 = sysdate.Subtract(date1);
                  return (int)(date3.Days / 365);                          
            }
        }
        
        public int [] Sides; //масив розмірів
        public double V { get { return Sides[0]*Sides[1]*Sides[2]/1000000.0 ; } } //Об'єм
        
        public List<string> features;
        public PowerTool(int Number, string Price,string Name, int Day, int Month ,int Year, int PowerType,string Country, string photo_file_name="")
        { 
            this.Number = Number;
            this.Price = Price;
            this.Name = Name;
            this.Day = Day; 
            this.Month = Month; 
            this.Year = Year; 
            this.PowerType = PowerType;
            this.Country = Country;
            this.photo_file_name = photo_file_name;
            Sides = new int[3];
            features = new List<string>();
        }

        public PowerTool(PowerTool p)
        {
            this.Number = p.Number;
            this.Price = p.Price;
            this.Name = p.Name;
            this.Day = p.Day;
            this.Month = p.Month;
            this.Year = p.Year;
            this.PowerType = p.PowerType;
            this.Country = p.Country;
            this.photo_file_name = p.photo_file_name;
            Sides = new int[3];
            Sides[0] = p.Sides[0];
            Sides[1] = p.Sides[0];
            Sides[2] = p.Sides[0];
            features = new List<string>();
            features = p.features;
        }

        public PowerTool()
        { PowerType = 1; }
              
        public virtual double DeliveryPrice()//ціна доставки
        {
            return 50;
        }
        public virtual double ActionPricepercent()//знижка % в залежності від давності товару
        {
            return 0;
        }
        public double ActionPrice { get { return double.Parse(Price) * (100.0 - ActionPricepercent()) / 100.0; } }//Акційна ціна, що враїовує знижку
    }
}
