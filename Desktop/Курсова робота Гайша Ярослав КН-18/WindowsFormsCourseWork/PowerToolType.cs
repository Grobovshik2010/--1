using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsCourseWork
{
    [Serializable] 
    public class PowerToolType
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public PowerToolType(int Number, string Name)

        {
            this.Number = Number;
            this.Name = Name; 
        }
        public PowerToolType()
        { }  
    }
}
