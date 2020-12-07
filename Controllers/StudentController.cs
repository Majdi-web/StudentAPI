using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Kubernetes8.Controllers
{
    public class StudentController : Controller
    {


        static IList<Models.Student> studentList = new List<Models.Student>{
                new Models.Student() { MasterStudentId = 1, MasterStudentName = "Majdi Jaradat", Age = 47 } ,
                new Models.Student() { MasterStudentId = 2, MasterStudentName = "Ahmad Abdelbaset",  Age = 26 } ,
                new Models.Student() { MasterStudentId = 3, MasterStudentName = "Saad Alssad ",  Age = 26 } ,
                new Models.Student() { MasterStudentId = 4, MasterStudentName = "Rami Nihad" , Age = 25 } ,
                new Models.Student() { MasterStudentId = 5, MasterStudentName = "Mohammad Sami" , Age = 31 } ,
                new Models.Student() { MasterStudentId = 4, MasterStudentName = "Sami Amer" , Age = 33 } ,
                new Models.Student() { MasterStudentId = 4, MasterStudentName = "Ali Ahmad" , Age = 19 } ,
            };






        public ActionResult View2()
        {
            //fetch students from the DB using Entity Framework here

            return View(studentList);
        }

    }
}
