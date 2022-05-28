using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.EmployeeService;

namespace EmployeeManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        #region Property  
        private readonly IEmployeeService _EmployeeService;
        #endregion

        #region Constructor  
        public EmployeeController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;
        }
        #endregion

        [HttpGet(nameof(GetEmployee))]
        public IActionResult GetEmployee(int id)
        {
            var result = _EmployeeService.GetEmployee(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet(nameof(GetAllEmployee))]
        public IActionResult GetAllEmployee()
        {
            var result = _EmployeeService.GetAllEmployees();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpPost(nameof(InsertEmployee))]
        public IActionResult InsertEmployee(Employee employee)
        {
            _EmployeeService.InsertEmployee(employee);
            return Ok("Data inserted");

        }
        [HttpPut(nameof(UpdateEmployee))]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _EmployeeService.UpdateEmployee(employee);
            return Ok("Updation done");

        }
        [HttpDelete(nameof(DeleteEmployee))]
        public IActionResult DeleteEmployee(int Id)
        {
            _EmployeeService.DeleteEmployee(Id);
            return Ok("Data Deleted");

        }
    }
}
