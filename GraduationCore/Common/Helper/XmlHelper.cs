using System;
using System.Xml.Serialization;
using System.IO;

namespace GraduationCore.Common.Helper
{
    public class XmlHelper
    {
        public static object GetXmlInstance<T>(string path)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            try
            {
                using (TextReader reader = new StreamReader(path))
                {
                    return xml.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                Exception e=ex;
                return null;
            }
        }
    }
}