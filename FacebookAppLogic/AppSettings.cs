using System.IO;
using System.Xml.Serialization;

namespace FacebookAppLogic
{
    public class AppSettings
    {
        public string LastAccessToken{ get; set; }
        public bool RememberUser{ get; set; }

        private static readonly string sr_FileName;

        static AppSettings()
        {
            sr_FileName = @"../UserData.xml";

        }

        public void SaveToFile()
        {
            if (File.Exists(sr_FileName))
            {
                using (Stream stream = new FileStream(sr_FileName, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream(sr_FileName, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings objectApp = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    objectApp = (AppSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                objectApp = new AppSettings()
                                {
                                    RememberUser = false,
                                };
            }

            return objectApp;
        }
    }
}
