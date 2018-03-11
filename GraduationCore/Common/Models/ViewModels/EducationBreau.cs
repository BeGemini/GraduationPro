using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GraduationCore.Common.Models.ViewModels
{
    [Serializable]
    [XmlRoot("EducationBureauList")]
    public class EducationBureauList:List<EducationBureau>
    {}
    public class EducationBureau
    {
        [XmlAttribute]
        public string Name{get;set;}
        [XmlAttribute]
        public string Address{get;set;}
        [XmlAttribute]
        public string Tel{get;set;}
        [XmlAttribute]
        public string Remark{get;set;}
    }
}