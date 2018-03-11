namespace GraduationCore.Common. Models.DataModels
{
    public class MStudents
    {
        public int ID{get;set;}

        public string CountiesNum{get;set;}

        public string PoliceStationNum{get;set;}

        public string StreetNum{get;set;}

        public string CommiteeNum{get;set;}

        public string SName{get;set;}

        public string SIdentity{get;set;}

        public int Sex{get;set;}

        public int IsLocal{get;set;}//是否城区

        public string Contacts{get;set;}

        public string ContactInfo{get;set;}

        public string CurrentAddress{get;set;}

        public string EnterTime{get;set;}

        public string LastupdateTime{get;set;}

        public string IP{get;set;}

        public int IsAdmitted{get;set;}
    }
}