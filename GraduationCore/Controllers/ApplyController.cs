using System;
using Microsoft.AspNetCore.Mvc;
using GraduationCore.Common.Models.ViewModels;
using GraduationCore.Common.Helper;
using GraduationCore.Common.Models.DataModels;
using Microsoft.AspNetCore.Http;

public class ApplyController : Controller
{
    [HttpGet]
    public IActionResult RedirectToApplyPage(string idNumber, string isLocal)
    {
        ResultData<string> result = new ResultData<string>();
        if (idNumber.Length != 18)
        {
            result.Status = ResultStauts.Error;
            result.Msg = "身份证号输入错误，不足18位！";
        }
        else
        {
            if (RegularHelper.CheckIdNumber18(idNumber))
            {
                IdNumber id = new IdNumber(idNumber);
                #region 与规定报名年限不符
                if (Convert.ToDateTime(id.BirthDay) == DateTime.Now)
                {
                    result.Status = ResultStauts.Error;
                    result.Msg = "您的年龄与规定报名年限不符！如有疑问，请联系长春市教育局！";
                }
                #endregion
                else
                {
                    result.Status = ResultStauts.Success;
                    result.Data = $"/Apply/ApplyPage?idNumber={DESEncryptHelper.DesEncrypt(idNumber)}&isLocal={DESEncryptHelper.DesEncrypt(isLocal)}";
                }
            }
            else
            {
                result.Status = ResultStauts.Error;
                result.Msg = "身份证号错误，请核实！";
            }
        }
        return Json(result);
    }

    public IActionResult ApplyPage(string idNumber, string isLocal)
    {
        idNumber = DESEncryptHelper.DesDecrypt(idNumber);
        isLocal = DESEncryptHelper.DesDecrypt(isLocal);
        IdNumber id = new IdNumber(idNumber);
        id.IsLocal = int.Parse(isLocal);
        ViewData["idNum"] = id;
        return View();
    }

    public IActionResult ValidateCode()
    {
        RandomCodeHelper helper = new RandomCodeHelper();
        string code = string.Empty;
        System.IO.MemoryStream memoryStream = helper.Create(out code);
        Response.Body.Dispose();
        return File(memoryStream.ToArray(), @"image/png");
    }

    public ResultData<string> CheckStudentInfo(MStudents students)
    {
        ResultData<string> result=new ResultData<string>();
        return result;
    }

    // [HttpPost]
    // public async Task<IActionResult> InsertStudents(FormCollection collection)
    // {
    //     string id=collection["SIdentity"].ToString();
    //     IdNumber idNumber=new IdNumber(id);
    //     if(idNumber.Sex==1)
    //     {
    //         var students=await TryUpdateModelAsync<MStudents>(collection);
    //     }
    //     return Json("");
    // }
}