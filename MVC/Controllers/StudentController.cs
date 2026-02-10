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
        [ValidateAntiForgeryToken]
        public ActionResult Add(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); // 校验失败仍返回表单页面
            }

            using (studyCEntities1 db = new studyCEntities1())
            {
                db.Student.Add(model);
                db.SaveChanges();
            }
            // 保存逻辑...
            // 成功后返回脚本：在 iframe 内获取父 layer 索引并关闭，刷新父页面
            var script = "<script>var idx = parent.layer.getFrameIndex(window.name); parent.layer.close(idx); parent.location.reload();</script>";
            return Content(script, "text/html");
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
        [ValidateAntiForgeryToken]
        public ActionResult Update(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (studyCEntities1 db = new studyCEntities1())
            {
                Student student = db.Student.Where(s => s.ID == model.ID).FirstOrDefault();
                student.Name = model.Name;
                student.Sex = model.Sex;
                student.Age = model.Age;
                student.Class = model.Class;
                db.SaveChanges();
            }
            // 更新逻辑...
            var script = "<script>var idx = parent.layer.getFrameIndex(window.name); parent.layer.close(idx); parent.location.reload();</script>";
            return Content(script, "text/html");
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