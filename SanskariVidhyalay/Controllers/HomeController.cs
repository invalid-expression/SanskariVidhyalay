using Microsoft.AspNetCore.Mvc;
using SanskariVidhyalay.Migrations.ContactDBMigrations;
using SanskariVidhyalay.Model;
using SanskariVidhyalay.Models;
using SanskariVidhyalay.Services;
using System.Diagnostics;

namespace SanskariVidhyalay.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentEntriesService _studentEntriesService;
        private readonly IContact _contact;

        public HomeController(ILogger<HomeController> logger, IStudentEntriesService studentEntriesService, IContact contact)
        {
            _logger = logger;
            _studentEntriesService = studentEntriesService;
            _contact = contact;         
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
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
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
            return View(viewModel);
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
