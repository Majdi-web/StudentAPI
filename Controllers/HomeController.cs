using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Kubernetes8.Models;

namespace Kubernetes8.Controllers
{
    public class HomeController : Controller
    {


        static IList<Models.Student> studentList = new List<Models.Student>{
                new Models.Student() { MasterStudentId = 1, MasterStudentName = "Majdi Jaradat", Age = 47, Address= " RAMALLAH", Occupation= "IT Director", Company= " Ministry Of Works" } ,
                new Models.Student() { MasterStudentId = 2, MasterStudentName = "Ahmad Abdelbaset",  Age = 26, Address= " Jerusalem", Occupation= " Developer", Company= " ===="  } ,
                new Models.Student() { MasterStudentId = 3, MasterStudentName = "Saad Alsaad",  Age = 27, Address= " Jenin", Occupation= " Developer", Company= "Hari" } ,
                new Models.Student() { MasterStudentId = 4, MasterStudentName = "Rami Ahmad" , Age = 25, Address= " RAMALLAH" } ,
                new Models.Student() { MasterStudentId = 5, MasterStudentName = "Sami Ali" , Age = 31, Address= " RAMALLAH" } ,
                new Models.Student() { MasterStudentId = 6, MasterStudentName = "Riyad Ahmad" , Age = 33, Address= " RAMALLAH" } ,
                new Models.Student() { MasterStudentId = 7, MasterStudentName = "Mohammad Radi" , Age = 40, Address= " RAMALLAH" } ,
                new Models.Student() { MasterStudentId = 8, MasterStudentName = "Shadi Matar" , Age = 45, Address= " RAMALLAH" } ,
            };






        public ActionResult Index()
        {
            //fetch students from the DB using Entity Framework here

            return View(studentList);
        }

    }
}
