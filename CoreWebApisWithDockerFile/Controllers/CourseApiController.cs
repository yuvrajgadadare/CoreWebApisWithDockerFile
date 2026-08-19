using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreWebApisWithDockerFile.Models;
namespace CoreWebApisWithDockerFile.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class CourseApiController : ControllerBase
    {
        CiitstudContext db;
        public CourseApiController(CiitstudContext db)
        {
            this.db = db;
        }
        [HttpGet]
        [Route("api/course")]
        public List<TbltrainingCourse> GetCourses()
        {
            return db.TbltrainingCourses.ToList();
        }
        [HttpGet]
        [Route("api/course/{id}")]
        public TbltrainingCourse  GetCourse(int id)
        {
            return db.TbltrainingCourses.Find(id);
        }

 [HttpGet]
        [Route("api/demoapi")]
        public string  SampleGetApi()
        {
            return "Welcome to DemoApi";
        }

    }
}
