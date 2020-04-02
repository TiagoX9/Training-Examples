using Demo4.Web.Data;
using Demo4.Web.Models;
using Demo4.Web.Models.EditModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo4.Web.Controllers
{
    public class TimeEntryController : Controller
    {
        private readonly HrManagementContext _context;
        public TimeEntryController(HrManagementContext context)
        {
            _context = context;
        }

        public IActionResult Create(int id)
        {
            return View("CreateEdit", new TimeEntryEditModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(TimeEntryEditModel editModel)
        {
            var timeEntryToAdd = new TimeEntry
            {
                DateLogged = editModel.DateLogged,
                HoursWorked = editModel.HoursWorked,
                EmployeeId = editModel.EmployeeId
            };

            _context.Add(timeEntryToAdd); // EntityState.Added
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Employee");
        }

    }
}
