using System;
using System.Collections.Generic;

namespace WindowsFormsCourseWork
{
    [Serializable]
    public class Data
    {
        public List<PowerTool> lstPT;
        public List<PowerToolType> lstT;
        public Data(){}
        public Data(bool iserror) 
        {
            
                lstPT = new List<PowerTool>();
                lstT = new List<PowerToolType>();
                if (!iserror)
                {
                lstT.Add(new PowerToolType(1, "Шуруповерти"));
                lstT.Add(new PowerToolType(2, "Дрилі"));
                lstT.Add(new PowerToolType(3, "Перфоратори"));
                lstT.Add(new PowerToolType(4, "Болгарки"));
                lstT.Add(new PowerToolType(5, "Пилки"));
                lstT.Add(new PowerToolType(6, "Шліфмашинки"));

                lstPT.Add(new PowerTool(01, "1 566", "Пила циркулярная DWT HKS12-54", 1, 1, 2019, 1, "1","1.jpg"));
                lstPT.Add(new PowerTool(02, "3 599", "Дрель-шуруповерт Bosch Professional GSR 12V-30", 23, 7, 2019, 2,"2", "2.jpg"));
                lstPT.Add(new PowerTool(03, "1 499", "Угловая шлифмашина Bosch PWS 850-125", 27, 7, 2018, 6, "4","3.jpg"));
                lstPT.Add(new PowerTool(04, "3599", "Перфоратор Bosch Professional GBH 2-24 DRE", 27, 8, 1997, 3, "4", "4.jpg"));
                }
        }
    }
}
