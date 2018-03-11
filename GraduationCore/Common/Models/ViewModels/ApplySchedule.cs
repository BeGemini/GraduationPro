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
        public string TextClass
        {
            get
            {
                if (DateTime.Compare(DateTime.Now.AddDays(-1), DateTime.Now) > 0)
                    return "text-primary";
                else
                    return "text";
            }
        }
    }
}