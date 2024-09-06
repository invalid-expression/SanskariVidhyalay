using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using NuGet.Protocol;
using SanskariVidhyalay.Migrations.ContactDBMigrations;
using SanskariVidhyalay.Model;
using SanskariVidhyalay.Models;
using SanskariVidhyalay.Services;
using System.Data;
using System.Diagnostics;
using System.Dynamic;

namespace SanskariVidhyalay.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentEntriesService _studentEntriesService;
        private readonly IContact _contact;
        private readonly ICities _cities;
        private readonly StudentEntriesDB _studentEntriesContext;
        public HomeController(ILogger<HomeController> logger, IStudentEntriesService studentEntriesService, IContact contact, ICities cities, StudentEntriesDB studentEntriesContext)
        {
            _logger = logger;
            _studentEntriesService = studentEntriesService;
            _contact = contact;
            _cities = cities;
            _studentEntriesContext = studentEntriesContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StudentDetails(Models.StudentEntries student)
        {
            if (ModelState.IsValid)
            {
                _studentEntriesService.AddStudent(student);
                _cities.GetAllCities().ToList();

                return RedirectToAction("Success");
            }
            return View();
        }

        public IActionResult Edit(int StudentID)
        {
            var StudentEdit = _studentEntriesContext.StudentEntries.FirstOrDefault(e => e.StudentID == StudentID);
            return View(StudentEdit);
        }

        public IActionResult Update(StudentEntries student, string Edit)
        {
            if (Edit == "Update")
            {
                var old_student_entries = _studentEntriesContext.StudentEntries.FirstOrDefault(e => e.StudentID == student.StudentID);
                _studentEntriesContext.Entry(old_student_entries).CurrentValues.SetValues(student);
                _studentEntriesContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                _studentEntriesService.AddStudent(student);
                _cities.GetAllCities().ToList();
                return RedirectToAction("Success");
            }
            
        }
        public IActionResult Delete(int StudentID)
        {
            var Data = _studentEntriesContext.StudentEntries.FirstOrDefault(e => e.StudentID == StudentID);
            _studentEntriesContext.StudentEntries.Remove(Data);
            _studentEntriesContext.SaveChanges();
            return RedirectToAction("Index","Admin");
        }


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Deleted()
        {
            return View("SuccessMessage/Deleted");
        }

        public IActionResult Success()
        {
            return View("SuccessMessage/Success");
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            try
            {
                _logger.LogTrace("This is a Trace log, the most detailed information.");
                _logger.LogDebug("This is a Debug log, useful for debugging.");
                _logger.LogInformation("This is an Information log, general info about app flow.");
                _logger.LogWarning("This is a Warning log, indicating a potential issue.");
                _logger.LogCritical("This is a Critical log, indicating a serious failure in the application.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"This is an Error log, indicating a failure in the current operation.{ex}");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Models.Contact Contact)
        {
            if (ModelState.IsValid)
            {
                _contact.AddContact(Contact);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult AddmissionCriteria()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }

        public IActionResult Academics()
        {
            return View();
        }

        public IActionResult Departments()
        {
            return View();
        }

        public IActionResult Admin()
        {
            var viewModel = new Listofmodel
            {
                StudentEntries = _studentEntriesService.GetAllStudents().ToList(),
                Contacts = _contact.GetAllContact().ToList()
            };

            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            {
                return RedirectToAction("Login", "Home");
            }
            return View(viewModel);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "admin" && model.Password == "password")
                {

                    HttpContext.Session.SetString("Username", model.Username);
                    return RedirectToAction("Admin");
                }
                else
                {
                    if (model.Password != "password" && model.Username != "admin")
                    {
                        ModelState.AddModelError("Password", "Invalid password.");
                        ModelState.AddModelError("Username", "Invalid username.");
                    }
                    else if (model.Password != "password")
                    {
                        ModelState.AddModelError("Password", "Invalid password.");
                    }
                    else if (model.Username != "admin")
                    {
                        ModelState.AddModelError("Username", "Invalid username.");
                    }
                    
                }
            } 
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
