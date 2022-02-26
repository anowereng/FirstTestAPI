using Microsoft.AspNetCore.Mvc;

namespace FirstTestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        // GET: api/student
        [HttpGet]
        public ActionResult GetAllStudents()
        {
            try
            {
                // demo operation , change your requirement 
                var data = StudentData.GetStudentList();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/student/1

        [HttpGet("{id}")]
        public ActionResult GetStudent(int id)
        {
            try
            {
                // demo operation , change your requirement 
                List<Student> data = StudentData.GetStudentList();

                var result = data.Where(x => x.Id == id).SingleOrDefault();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // GET: api/student
        [HttpPost]
        public ActionResult SaveStudent(Student student)
        {
            try
            {
                // demo operation , change your requirement 
                var data = new List<Student>() { student };

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // GET: api/student/1
        [HttpPut("{id}")]
        public ActionResult UpdateStudent( int id, Student student)
        {
            try
            {
                // demo operation , change your requirement 
                var data = StudentData.GetStudentList();
                var studentData = data.Where(x => x.Id == id).SingleOrDefault();
                
                return Ok(studentData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        // GET: api/student/1
        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            try
            {
                // demo operation , change your requirement 
                var data = StudentData.GetStudentList().Where(x => x.Id == id).SingleOrDefault();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}