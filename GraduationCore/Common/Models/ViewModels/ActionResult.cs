namespace GraduationCore.Common.Models.ViewModels
{
    public enum ResultStauts
    {
        Error=0,
        Success,
        Exception
    }
    public class ResultData<T>
    {
        public T Data { get; set; }//返回数据

        public ResultStauts Status { get; set; }//返回状态

        public string Msg { get; set; }=string.Empty;
    }
}
