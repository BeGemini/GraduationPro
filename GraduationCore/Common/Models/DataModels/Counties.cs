namespace GraduationCore.Common.Models.DataModels
{
    public class Counties
    {

        public int ID { get; set; }

        public string Number { get; set; }

        public string CName { get; set; }

        //小学兼报县区编码
        public string PCompatibilityCounty { get;set; }

        //中学兼报县区编码
        public string MCompatibilityCounty{get;set;}
    }
}