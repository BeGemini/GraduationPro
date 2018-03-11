namespace GraduationCore.Common.Models.DataModels
{
    public class MSchools
    {
        public int ID{get;set;}

        public string CountiesNum{get;set;}

        public string MNumber{get;set;}

        public string MName{get;set;}

        public int IsDominator{get;set;}//是否优质学校

        public int? EnrolNum{get;set;}//优质招生人数
    }
}