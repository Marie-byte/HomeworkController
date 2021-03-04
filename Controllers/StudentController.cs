using Microsoft.AspNetCore.Mvc;
using Homework.Data;
using Homework.DTO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController :ControllerBase
    {
        private readonly Context _context;

        public StudentController(Context context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetStudents()
        {
            var student = from students in _context.Student
            join studentdescription in _context.Studentdescription on students.id equals studentdescription.student_id
            select new StudentDTO
            {
                Students_Id = students.id,
                Age = studentdescription.age,
                First_name = studentdescription.first_name,
                Last_name = studentdescription.last_name,
                Country = studentdescription.country
            };
            return await student.ToListAsync();
        }

        [HttpGet("{id}")]
        public ActionResult<StudentDTO> GetStudentById(int id)
        {
            var student = from students in _context.Student
            join studentdescription in _context.Studentdescription on students.id equals studentdescription.student_id
            select new StudentDTO
            {
                Students_Id = students.id,
                Age = studentdescription.age,
                First_name = studentdescription.first_name,
                Last_name = studentdescription.last_name,
                Country = studentdescription.country
            };
            var student_by_id = student.ToList().Find(x => x.Students_Id == id);
            if(student_by_id == null)
            {
                return NotFound();
            }
            return student_by_id;
        }
    }
}