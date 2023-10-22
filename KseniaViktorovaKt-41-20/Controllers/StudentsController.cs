using KseniaViktorovaKt_41_20.Interfaces.StudentsInterfaces;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost(Name = "GetStudents")]
        public async Task<IActionResult> GetStudentsAsync(CancellationToken cancellationToken = default)
        {
            var students = await _studentService.GetStudentsAsync(cancellationToken);
            return Ok(students);
        }
    }
}
