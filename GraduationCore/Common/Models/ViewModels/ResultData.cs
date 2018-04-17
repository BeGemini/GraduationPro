namespace GraduationCore.Common.Models.ViewModels
{
    public enum ResultMessage
    {
        Error=0,
        Success
    }
    public class ResultData<T>
    {


        public ResultData()
        {
            MsgDetail = string.Empty;
        }

        public T Data { get; set; }//返回数据

        public ResultMessage Msg { get; set; }//返回状态

        public string MsgDetail { get; set; }
    }
}
