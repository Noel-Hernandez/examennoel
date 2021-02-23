using Lab3_08_01_2021.Models;
using Lab3_08_01_2021.Models.Data;
using Lab3_08_01_2021.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Lab3_08_01_2021.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        StudentData studentData;
        ContactData contactData;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Insert([FromBody] Student student)
        {
            studentData = new StudentData(_configuration);

            //llamada al modelo para insertar el estudiante
            // studentData.Insert(student);
            int resultToReturn = studentData.Insert(student);
            return Ok(resultToReturn);
        }
        public IActionResult InsertData1([FromBody] Contact contact)
        {
            contactData = new ContactData(_configuration);

            //llamada al modelo para insertar el estudiante
            // studentData.Insert(student);
            int resultToReturn = contactData.InsertData(contact);
            return Ok(resultToReturn);
        }


        public IActionResult GetStudents()
        {

            //llamada al modelo para obtener los estudiantes
            studentData = new StudentData(_configuration);
            return Ok(studentData.GetStudents());
        }

        public IActionResult GetNationality()
        {

            //llamada al modelo para obtener los estudiantes
            studentData = new StudentData(_configuration);
            return Ok(studentData.GetNationality());
        }
        public IActionResult GetMajor()
        {

            //llamada al modelo para obtener los estudiantes
            studentData = new StudentData(_configuration);
            return Ok(studentData.GetMajor());
        }

        /*public IActionResult DeleteStudent([FromBody] int id)
        {

            //llamada al modelo para obtener los estudiantes
            studentData = new StudentData(_configuration);
            return Ok(studentData.Delete(id));
        }
        public IActionResult UpdateStudent(Student student)
        {

            //llamada al modelo para obtener los estudiantes
            studentData = new StudentData(_configuration);
            return Ok(studentData.Update(student));
        }*/

        public void SendEmail(Contact contact)
        {
            try
            {

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("from");
                mailMessage.To.Add("destinatario");
                mailMessage.Subject = "Reclutando información de Interesados";
                mailMessage.Body = "El siguiente Interesados:" + contact.NameContact + ", desea saber la siguiente información:" + contact.InformationContact + ", el correo electronico es:" + contact.EmailContact;

                System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("correoUser", "suContraseña");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                //Response.Write("Correo Envíado");
                //HttpContext.Session.SetString("entro", "Se envió un correo de confirmación");
            }
            catch (Exception ex)
            {
            }

        }
    }
}

