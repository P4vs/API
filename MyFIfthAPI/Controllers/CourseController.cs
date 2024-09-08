using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstDapper.Model;
using MyFirstDapper.Service;

namespace MyFIfthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        [HttpPost]
        public bool AddCourse(CourseModel course)
        {
            CourseService courseService = new CourseService();
            courseService.AddCourse(course);
            return true;
        }

    }
}
