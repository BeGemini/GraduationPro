using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GraduationCore.Models;
using GraduationCore.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace GraduationCore.Controllers
{
    public class HomeController : Controller
    {
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
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
