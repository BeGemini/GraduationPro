public class ResultData<T>
{
    public ResultData()
    {
        Code=200;
        Msg=string.Empty;
    }

    public int Code{get;set;}//返回码

    public T Data{get;set;}//返回数据

    public string Msg{get;set;}//返回消息
}