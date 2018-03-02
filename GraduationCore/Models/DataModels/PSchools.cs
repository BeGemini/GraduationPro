using System;
namespace GraduationCore.Models.DataModels
{
    public class PSchools
    {
        public int ID{get;set;}

        public string CountiesNum{get;set;}//县区编码 

        public string PNumber{get;set;}//学校编码

        public string PName{get;set;}//学校名称

        public int IsDominator{get;set;}//是否优质学校

        public int? EnrollNum{get;set;}//优质招生人数
    }
}