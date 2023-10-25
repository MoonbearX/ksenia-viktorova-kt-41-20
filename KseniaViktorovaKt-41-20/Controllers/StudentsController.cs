using KseniaViktorovaKt_41_20.Interfaces.StudentsInterfaces;
using KseniaViktorovaKt_41_20.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace KseniaViktorovaKt_41_20.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : Controller
    {
        private readonly ILogger<StudentsController> logger;
        private readonly IStudentService _studentService;

        public StudentsController(ILogger<StudentsController> logger, IStudentService studentService)
        {
            this.logger = logger;
            _studentService = studentService;
        }

        [HttpGet("Get students")]
        public async Task<IActionResult> GetStudentsAsync(CancellationToken cancellationToken = default)
        {
            var students = await _studentService.GetStudentsAsync(cancellationToken);
            return Ok(students);
        }

        [HttpGet("Get students with id")]
        public async Task<ActionResult<Student>> GetStudentAsync(int id, CancellationToken cancellationToken = default)
        {
            var student = await _studentService.GetStudentAsync(id, cancellationToken);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost("Add students")]
        [ActionName(nameof(AddStudentAsync))]
        public async Task<IActionResult> AddStudentAsync(Student student, CancellationToken cancellationToken = default)
        {
            await _studentService.AddStudentAsync(student, cancellationToken);
            return CreatedAtAction(nameof(AddStudentAsync), new { id = student.Id }, student);
        }

        [HttpPut("Update student with id")]
        public async Task<IActionResult> UpdateStudentAsync(int id, Student student, CancellationToken cancellationToken = default)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }
            await _studentService.UpdateStudentAsync(student, cancellationToken);
            return NoContent();
        }

        [HttpDelete("Delete students with id")]
        public async Task<IActionResult> DeleteStudentAsync(int id, CancellationToken cancellationToken = default)
        {
            var student = await _studentService.GetStudentAsync(id, cancellationToken);
            if (student == null)
            {
                return NotFound();
            }
            await _studentService.DeleteStudentAsync(student, cancellationToken);
            return Ok(student);
        }
    }
}
