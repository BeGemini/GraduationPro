using System;
namespace GraduationCore.Models.DataModels
{
    //原始报名数据，不对此表做修改
    public class PStudents
    {
        public int ID{get;set;}

        public string CountiesNum{get;set;}//县区编码

        public string Name{get;set;}

        public string SIdentity{get;set;}//身份证号

        public int Sex{get;set;}

        public string Contacts{get;set;}//联系人

        public string ContactInfo{get;set;}//联系方式

        public string CurrentAddress{get;set;}//现居住地

        public DateTime LastupdateTime{get;set;}//报名时间

        public string IP{get;set;}//报名IP
    }
}