using Microsoft.AspNetCore.Mvc;
using GraduationCore.Common.Models.ViewModels;

public class ApplyController : Controller
{
    [HttpGet]
    public IActionResult RedirectToApplyPage(string idNumber)
    {
        ResultData<string> result = new ResultData<string>();
        if(idNumber.Length!=18)
        {
            result.Msg=ResultMessage.Error;
        }
        return Json("");
    }

    public IActionResult MiddleApply()
    {
        return View();
    }

    public IActionResult PrimaryApply()
    {
        return View();
    }
}