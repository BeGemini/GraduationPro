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
        public string WebName{get;set;}
        [XmlAttribute]
        public string WebLink{get;set;}
        //咨询电话
        [XmlAttribute]
        public string ConsultNum{get;set;}
        //监督举电话
        [XmlAttribute]
        public string SuperviseNum{get;set;}
        [XmlAttribute]
        public string Remark{get;set;}
    }
}