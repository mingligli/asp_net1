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
        // 修改Index方法，添加分页参数
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            // 总记录数
            int totalCount = 0;
            IList<Student> students = null;

            using (studyCEntities1 db = new studyCEntities1())
            {
                // 获取总记录数
                totalCount = db.Student.Count();

                // 分页查询：Skip(跳过的记录数) Take(获取的记录数)
                students = db.Student
                    .OrderBy(s => s.ID)
                    .Skip((page - 1) * pageSize)  // 跳过前面的记录
                    .Take(pageSize)               // 获取当前页的记录
                    .ToList();
            }

            // 将分页信息传递到视图
            ViewBag.TotalCount = totalCount;    // 总记录数
            ViewBag.CurrentPage = page;         // 当前页码
            ViewBag.PageSize = pageSize;        // 每页条数
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalCount / pageSize); // 总页数

            return View(students);
        }

        // 以下原有方法保持不变
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
                return View(model);
            }

            using (studyCEntities1 db = new studyCEntities1())
            {
                db.Student.Add(model);
                db.SaveChanges();
            }
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
            var script = "<script>var idx = parent.layer.getFrameIndex(window.name); parent.layer.close(idx); parent.location.reload();</script>";
            return Content(script, "text/html");
        }

        [HttpPost] // 补充HttpPost特性，确保安全
        [ValidateAntiForgeryToken] // 补充防伪验证
        public ActionResult Delete(int id)
        {
            using (studyCEntities1 db = new studyCEntities1())
            {
                Student stu = db.Student.Where(s => s.ID == id).FirstOrDefault();
                if (stu != null) // 增加空值判断
                {
                    db.Student.Remove(stu);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}