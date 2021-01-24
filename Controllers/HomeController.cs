using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Kubernetes12.Models;
using System.Data.SqlClient;

namespace Kubernetes12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //  public IActionResult Index()
        //  {


        //      SqlConnection conn = new SqlConnection();
        //      conn.ConnectionString = "data source=localhost;initial catalog=containerdb;user id=sa;password=1234@abcd";
        //      String sql = "SELECT * FROM pro";
        //      SqlCommand cmd = new SqlCommand(sql, conn);


        //     conn.Open();
        //      SqlDataReader rdr = cmd.ExecuteReader();
        //      var model = new List<pro>();
        //      while (rdr.Read())
        //      {
        //          var student = new pro();
        //          student.proId = (int)rdr["proId"];
        //          student.proName = (string)rdr["proName"];
        //          model.Add(student);
        //      }

        //      return View(model);
        //  }






        //   public IActionResult students()
        //  {


        //       SqlConnection conn = new SqlConnection();
        //       conn.ConnectionString = "data source=localhost;initial catalog=containerdb;user id=sa;password=1234@abcd";
        //       String sql = "SELECT * FROM pro";
        //       SqlCommand cmd = new SqlCommand(sql, conn);


        //       conn.Open();
        //       SqlDataReader rdr = cmd.ExecuteReader();
        //       var model = new List<pro>();
        //       while (rdr.Read())
        //       {
        //           var student = new pro();
        //           student.proId = (int)rdr["proId"];
        //           student.proName = (string)rdr["proName"];
        //           model.Add(student);
        //       }

        //       return View(model);
        //   }



        public IActionResult stu()
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=localhost;initial catalog=containerdb;user id=sa;password=1234@abcd";
            String sql = "SELECT * FROM students";
            SqlCommand cmd = new SqlCommand(sql, conn);


            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            var model = new List<studentss>();
            while (rdr.Read())
            {
                var studentss = new studentss();


                studentss.MasterStudentId = (int)rdr["MasterStudentId"];
                studentss.MasterStudentName = (string)rdr["MasterStudentName"];

                studentss.Age = (int)rdr["Age"];
                studentss.Address = (string)rdr["Address"];
                studentss.Occupation = (string)rdr["Occupation"];
                studentss.Company = (string)rdr["Company"];


                model.Add(studentss);
            }

            return View(model);
        }




        public IActionResult Student3()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=localhost;initial catalog=containerdb;user id=sa;password=1234@abcd";
            String sql = "SELECT * FROM students";
            SqlCommand cmd = new SqlCommand(sql, conn);


            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            var model = new List<studentss>();
            while (rdr.Read())
            {
                var studentss = new studentss();


                studentss.MasterStudentId = (int)rdr["MasterStudentId"];
                studentss.MasterStudentName = (string)rdr["MasterStudentName"];

                studentss.Age = (int)rdr["Age"];
                studentss.Address = (string)rdr["Address"];
                studentss.Occupation = (string)rdr["Occupation"];
                studentss.Company = (string)rdr["Company"];


                model.Add(studentss);
            }

            return View(model);

        }

        public ActionResult Edit(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=localhost;initial catalog=containerdb;user id=sa;password=1234@abcd";
            String sql = "SELECT * FROM students";
            SqlCommand cmd = new SqlCommand(sql, conn);


            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            var model = new List<studentss>();
            while (rdr.Read())
            {
                var studentss = new studentss();


                studentss.MasterStudentId = (int)rdr["MasterStudentId"];
                studentss.MasterStudentName = (string)rdr["MasterStudentName"];

                studentss.Age = (int)rdr["Age"];
                studentss.Address = (string)rdr["Address"];
                studentss.Occupation = (string)rdr["Occupation"];
                studentss.Company = (string)rdr["Company"];
               
               return View(model);
            }
            return RedirectToAction("student3");
        }

        [HttpPost]
        public ActionResult Edit(studentss rdr)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=localhost;initial catalog=containerdb;user id=sa;password=1234@abcd";
            String sql = "SELECT * FROM students";
            SqlCommand cmd = new SqlCommand(sql, conn);


            conn.Open();
            SqlDataReader rdr2 = cmd.ExecuteReader();
            var model = new List<studentss>();
            while (rdr2.Read())
            {
                var studentss = new studentss();


                studentss.MasterStudentId = (int)rdr2["MasterStudentId"];
                studentss.MasterStudentName = (string)rdr2["MasterStudentName"];

                studentss.Age = (int)rdr2["Age"];
                studentss.Address = (string)rdr2["Address"];
                studentss.Occupation = (string)rdr2["Occupation"];
                studentss.Company = (string)rdr2["Company"];
                model.Remove(rdr);

                model.Add(rdr);
             //  return View(rdr);
            }
            return RedirectToAction("edit");


        }
    }




}


