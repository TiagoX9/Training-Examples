using Demo4.Web.Data;
using Demo4.Web.Models;
using Demo4.Web.Models.EditModels;
using Demo4.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Demo4.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HrManagementContext _context;

        public EmployeeController(HrManagementContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employees = _context.Employees
                                    .Select(x => new EmployeeViewModel(x.Id, x.Name, x.Surname, 0))
                                    .ToList();

            //// DEMO 4 PART 2
            //var employees = _context.EmployeesWithTotalHours
            //                        .Select(x => new EmployeeViewModel(x.Id, x.Name, x.Surname, x.TotalHoursWorked))
            //                        .ToList();

            return View("List", employees);
        }

        public IActionResult Create()
        {
            return View("CreateEdit", new EmployeeEditModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeEditModel editModel)
        {
            var employeeToAdd = new Employee
            {
                Name = editModel.Name,
                Surname = editModel.Surname
            };

            _context.Add(employeeToAdd); // EntityState.Added
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var employee = _context.Employees.Where(q => q.Id == id)
                                             .Select(x => new EmployeeEditModel(x.Id, x.Name, x.Surname))
                                             .Single();

            return View("CreateEdit", employee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeEditModel editModel)
        {
            var employeeToUpdate = _context.Employees.Where(q => q.Id == editModel.Id).SingleOrDefault();

            //// DEMO 4 PART 3
            //var employeeToUpdate = _context.Employees.FromSqlInterpolated($"SELECT * FROM Employees WHERE Id = {editModel.Id}").SingleOrDefault();

            if (employeeToUpdate == null)
            {
                return NotFound();
            }

            employeeToUpdate.Name = editModel.Name;
            employeeToUpdate.Surname = editModel.Surname;

            _context.Update(employeeToUpdate); // EntityState.Modified
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var employeeToDelete = _context.Employees.Where(q => q.Id == id)
                                             .Single();

            _context.Remove(employeeToDelete); // EntityState.Deleted
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
