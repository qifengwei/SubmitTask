using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmitTask.Saved
{
    public static class UserPath
    {
        public static String savedpath = 
            System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
            "//SubmitTask//SerializationOverview.xml";
        public static String savedfolder =
            System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
            "//SubmitTask";

        public static void SerializerSaved()
        {
            var saved = Saved.SavedSetting.GetInstance(); 
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Saved.SavedSetting));
            //var path = Saved.UserPath.savedpath + "//SerializationOverview.xml";
            using (System.IO.FileStream file = new System.IO.FileStream(savedpath, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
            {
                writer.Serialize(file, saved);
            }
        }

        public static void DeserializeSaved()
        {
            var saved = Saved.SavedSetting.GetInstance();
            System.Xml.Serialization.XmlSerializer reader =
            new System.Xml.Serialization.XmlSerializer(typeof(Saved.SavedSetting));
            //var path = Saved.UserPath.savedpath + "//SerializationOverview.xml";
            using (System.IO.FileStream file = new System.IO.FileStream(savedpath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite))
            {
                saved = (Saved.SavedSetting)reader.Deserialize(file);
            }
        }
    }
}
