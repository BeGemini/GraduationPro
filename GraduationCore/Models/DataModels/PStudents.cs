using System;
namespace GraduationCore.Models.DataModels
{
    //原始报名数据，不对此表做修改
    public class PStudents
    {
        public int ID{get;set;}

        public string CountiesNum{get;set;}//县区编码
        
        public string PoliceStationNum{get;set;}//派出所编码

        public string StreetNum{get;set;}//街编码

        public string CommiteeNum{get;set;}//委编码

        public string SName{get;set;}//学生姓名

        public string SIdentity{get;set;}//身份证号

        public int Sex{get;set;}//学生性别

        public int IsLocal{get;set;}//是否本地

        public string Contacts{get;set;}//联系人

        public string ContactInfo{get;set;}//联系方式

        public string CurrentAddress{get;set;}//现居住地

        public DateTime EnterTime{get;set;}
        public DateTime LastupdateTime{get;set;}//报名时间

        public string IP{get;set;}//报名IP

        public int IsAdmitted{get;set;}//是否被录取
    }
}