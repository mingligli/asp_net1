using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            IList<Student> students = null;
            using (studyCEntities1 db = new studyCEntities1())
            {
                students = db.Student.Select(s => s).ToList();
            }
            return View(students);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Student stu)
        {
            using (studyCEntities1 db = new studyCEntities1())
            {
                db.Student.Add(stu);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Student stu = null;
            using (studyCEntities1 db = new studyCEntities1())
            {
                stu = db.Student.Where(s => s.ID == id).FirstOrDefault();
            }
            return View(stu);
        }
        [HttpPost]
        public ActionResult Update(Student stu)
        {
            using (studyCEntities1 db = new studyCEntities1())
            {
                Student student = db.Student.Where(s => s.ID == stu.ID).FirstOrDefault();
                student.Name = stu.Name;
                student.Sex = stu.Sex;
                student.Age = stu.Age;
                student.Class = stu.Class;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            using (studyCEntities1 db = new studyCEntities1())
            {
                Student stu = db.Student.Where(s => s.ID == id).FirstOrDefault();
                db.Student.Remove(stu);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}