using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lab3_08_01_2021.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_08_01_2021.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudents()
        {

            IEnumerable<Student> students = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44337/api/student/");
                var responseTask = client.GetAsync("GetStudents");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Student>>();
                    readTask.Wait();
                    //leen los estudiantes provenientes de la API
                    students = readTask.Result;
                }
                else
                {
                    students = Enumerable.Empty<Student>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact a administrator");
                }
            }

            return Json(students);
        }

    }
}
