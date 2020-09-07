
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsCourseWork
{
     public static class DataXmlSerilization
    {
        public static void save_to_xml(Data data, string FileName)
        {
             
            XmlSerializer save =  new XmlSerializer(typeof(Data));
            FileStream fs = new FileStream(FileName, FileMode.Create);  
            save.Serialize(fs, data);
            fs.Close();
        }
        public static Data read_from_xml(string FileName)
        {
            Data data;
            XmlSerializer read= new XmlSerializer(typeof(Data));
            FileStream fs;
            try 
            {
                fs = new FileStream(FileName, FileMode.Open);  
            }
            catch
            {
                data = new Data(true);
                return data;
            }

            data = (Data)read.Deserialize(fs);
            fs.Close();
            return data;
        }

    }
}
