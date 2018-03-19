using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace GraduationCore.Common.Models.ViewModels
{
    [Serializable]
    [XmlRoot("ApplyScheduleList")]
    public class ApplyScheduleList : List<ApplySchedule>
    { }
    [Serializable]
    public class ApplySchedule
    {
        [XmlAttribute]
        public string Title { get; set; }
        [XmlAttribute]
        public string BeginTime { get; set; }
        [XmlAttribute]
        public string EndTime { get; set; }
        //private DateTime beginTime=Convert.ToDateTime(BeginTime);
        public string TextClass
        {
            get
            {
                DateTime begin = Convert.ToDateTime(BeginTime);
                DateTime end = Convert.ToDateTime(EndTime);
                if (DateTime.Compare(DateTime.Now, begin) > 0 && DateTime.Compare(DateTime.Now, end) < 0)
                    return "text-primary";
                else
                    return "text";
            }
        }
    }
}