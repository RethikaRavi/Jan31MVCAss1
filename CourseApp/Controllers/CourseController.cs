using CourseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        // GET: Customer
        static List<Course> courses = new List<Course>()
  {
      new Course(){CId=1,CName="Full Stack Developer",CFee=32000,Technology="DotNet",CStartDate=new DateTime(day:1,month:2,year:2023),CEndDate=new DateTime(day:15,month:7,year:2023)},
      new Course(){CId=2,CName="Full Stack Developer",CFee=42000,Technology="Java",CStartDate=new DateTime(day:4,month:3,year:2023),CEndDate=new DateTime(day:4,month:8,year:2023)},
      new Course(){CId=3,CName="Testing",CFee=36000,Technology="Selenium",CStartDate=new DateTime(day:9,month:2,year:2023),CEndDate=new DateTime(day:7,month:10,year:2023)},
      new Course(){CId=4,CName="Testing",CFee=38000,Technology="Mocha",CStartDate=new DateTime(day:11,month:2,year:2023),CEndDate=new DateTime(day:12,month:6,year:2023)},
      new Course(){CId=5,CName="Full Stack Develper",CFee=40000,Technology="Python",CStartDate=new DateTime(day:14,month:2,year:2023),CEndDate=new DateTime(day:13,month:7,year:2023) }
  };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                courses.Add(course);
                return RedirectToAction("Index");
            }
            return View(courses);
        }


    }
}