using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstDapper.Model;
using MyFirstDapper.Service;

namespace MyFIfthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public bool AddStudent(StudentModel student)
        {
            studentService StudentService = new studentService();
            StudentService.AddStudent(student);
            return true;
        }
    }
}
