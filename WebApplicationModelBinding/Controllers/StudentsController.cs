using Microsoft.AspNetCore.Mvc;
using WebApplicationModelBinding.Models;

namespace WebApplicationModelBinding.Controllers
{
    public class StudentsController : Controller
    {
        static List<Student> students = new List<Student> {
         new Student(true){
             Name= "Aqil",
             Surname= "Abbasov",
             Age=20,
             Speciality="Front-End Developer"
         },
         new Student(true){
             Name= "Emil",
             Surname= "Quliyev",
             Age=21,
             Speciality="Back-end developer"
         },
        };

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Details(int id)
        {
            Student student = students.FirstOrDefault(m => m.Id == id);

            if (student == null)
                return NotFound(); 

            return View(student); 
        }


        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(Student student)
        {
            var entity = new Student(true)
            {
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age,
                Speciality = student.Speciality,
            };
            students.Add(entity);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Student entity = students.FirstOrDefault(m => m.Id == id);


            if (entity == null)
                return NotFound();

            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            //Linq

            Student entity = students.FirstOrDefault(m => m.Id == student.Id);


            if (entity == null)
                return NotFound();


            entity.Name = student.Name;
            entity.Surname = student.Surname;
            entity.Age = student.Age;
            entity.Speciality = student.Speciality;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int id)
        {
            Student entity = students.FirstOrDefault(m => m.Id == id);


            if (entity == null)
                return NotFound();

            students.Remove(entity);
            return RedirectToAction(nameof(Index));
        }
    }
}
