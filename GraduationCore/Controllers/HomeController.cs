using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GraduationCore.Common.Models.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using GraduationCore.Common.Models.ViewModels;
using GraduationCore.Common.Helper;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Linq;

namespace GraduationCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly string ConfigsPath;
        public HomeController(IHostingEnvironment _hostingEnvironment)
        {
            hostingEnvironment=_hostingEnvironment;
            ConfigsPath=Path.Combine(hostingEnvironment.ContentRootPath,"Common","Configs");
        }
        public IActionResult Index()
        {
            //DbContextOptions<GDBContext> x=new DbContextOptions<GDBContext>();
            // GDBContext dBContext=new GDBContext();
            // var tb =dBContext.Counties;
            // tb.Add(new Counties(){ID=1,Number="12",Name="南关"});
            // using (var dBContext = new GDBContext())
            // {
            //     dBContext.Database.EnsureCreated();
            //     var conties=new Counties()
            //     {
            //         Number="03",
            //         CName="绿园区"
            //     };
            //     dBContext.Add(conties);
            //     dBContext.SaveChanges();
            // }
            // var list=GetEducationBreauList();
            // ViewData[""]
            ViewBag.WarmPrompt=GetWarmPrompt();
            ViewBag.ApplyScheduleList=GetApplySheduleList();
            ViewBag.EducationBreauList=GetEducationBreauList();
            return View();
        }

        private List<EducationBureau> GetEducationBreauList()
        {
            return XmlHelper.GetXmlInstance<EducationBureauList>($"{ConfigsPath}/EducationBureau.xml") as List<EducationBureau>;
        }
        private List<ApplySchedule> GetApplySheduleList()
        {
            return XmlHelper.GetXmlInstance<ApplyScheduleList>($"{ConfigsPath}/ApplySchedule.xml")as List<ApplySchedule>;
        }
        private WarmPrompt GetWarmPrompt()
        {
            List<WarmPrompt> list=XmlHelper.GetXmlInstance<WarmPromptList>($"{ConfigsPath}/WarmPrompt.xml")as List<WarmPrompt>;
            var result= list.Where(w=>w.Visible).FirstOrDefault();
            if(result==null)
            {
                result=new WarmPrompt();
            }
            return result;
        }
        public IActionResult IdentityConfirm()
        {
            return View();
        }
    }
}
