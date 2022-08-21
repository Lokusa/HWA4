using HWA4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HWA4.Controllers
{
    public class HomeController : Controller
    {
        // Reposito

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Home()
        {

            return View(List.Subjects());
        }

        public ActionResult Math()
        {

            return View();
        }
        public ActionResult Science()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Maths(int subjectID, string subjectName, int num_Repeating_Students, int new_Students_Num, int study_Unit, int hoursPerweek)
        {
            Random random = new Random();
            int id = random.Next(1, 50000000);
            Maths maths = new Maths(subjectID,subjectName,  num_Repeating_Students,  new_Students_Num,  study_Unit,  hoursPerweek);
            List.Add(maths);

            return View();
        }

        [HttpPost]
        public ActionResult Science(int subjectID, string subjectName, int num_Repeating_Students, int new_Students_Num, string studyUnit_Content, int levelOfDifficulty)
        {
            int id = 0;
            Science science = new Science( subjectID,  subjectName,  num_Repeating_Students,  new_Students_Num,  studyUnit_Content, levelOfDifficulty);
            List.Add(science);
            id++;
            return View();
        }

        public ActionResult Delete(int id)
        {
            List.Delete(id);
            return RedirectToAction("Home");
        }

        public ActionResult UpdateMath(int id)
        {

            Maths plastic = (Maths)List.subjects.FirstOrDefault(x => x.SubjectID == id);
            return View(plastic);
        }

        public ActionResult UpdateSci(int id)
        {

            Science metal = (Science)List.subjects.FirstOrDefault(x => x.SubjectID == id);
            return View(metal);
        }

        [HttpPost]
        public ActionResult UpdateSci(Science science)
        {
            List.Edit(science);

            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult EditPlastic(Maths maths)
        {
            List.Edit(maths);

            return RedirectToAction("Home");
        }

        public ActionResult ViewAll()
        {
            ViewBag.Message = "all subjects.";

            return RedirectToAction("Home");
        }
    }
}