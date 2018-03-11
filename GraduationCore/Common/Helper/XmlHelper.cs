using System;
using System.Xml.Serialization;
using System.IO;

namespace GraduationCore.Common.Helper
{
    public class XmlHelper
    {
        static string BaseDirectory
        {
            get
            {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Common", "Config");
            }
        }

        public static object GetXmlInstance<T>(string xmlName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            try
            {
                using (TextReader reader = new StreamReader($"{BaseDirectory}/{xmlName}.xml"))
                {
                    return xml.Deserialize(reader);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}