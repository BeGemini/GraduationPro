using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GraduationCore.Common.Models.ViewModels
{
    [Serializable]
    [XmlRoot("WarmPromptList")]
    public class WarmPromptList : List<WarmPrompt>
    { }

    [Serializable]
    public class WarmPrompt
    {
        [XmlElement]
        public string Content { get; set; }
        [XmlElement]
        public string DisplayTime{get;set;}
        public bool Visible
        {
            get
            {
                DateTime begin = Convert.ToDateTime(DisplayTime.Split('^')[0]);
                DateTime end = Convert.ToDateTime(DisplayTime.Split('^')[1]);
                if (DateTime.Compare(DateTime.Now, begin) > 0 && DateTime.Compare(DateTime.Now, end) < 0)
                    return true;
                else
                    return false;
            }
        }
    }
}