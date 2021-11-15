using CRUDAPI.Models;
using CRUDAPI.Services.ProcessManager;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRUDAPI.Controllers
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentProcessManager _studentProcessManager;

        public StudentController(StudentProcessManager studentProcessManager)
        {
            _studentProcessManager = studentProcessManager;
        }
        public async Task<ActionResult> AddStudent(Student Student)
        {
            await _studentProcessManager.AddStudent(Student);
            return Ok();
        }
        public async Task<ActionResult> GetStudent([FromBody]string StudentId)
        {
            return Ok(await _studentProcessManager.GetStudent(StudentId));
        }
        public async Task<ActionResult> UpdateStudent(Student student)
        {
            if (await _studentProcessManager.UpdateStudent(student)!=null)
            return Ok();
            return NotFound("No student found with the given Id");
        }
        public async Task<ActionResult> DeleteStudent([FromBody]string StudentId)
        {
            await _studentProcessManager.DeleteStudent(StudentId);
            return Ok();
        }

    }
}
