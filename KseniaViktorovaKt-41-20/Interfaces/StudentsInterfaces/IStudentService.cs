using KseniaViktorovaKt_41_20.Data;
using KseniaViktorovaKt_41_20.Models;
using Microsoft.EntityFrameworkCore;


namespace KseniaViktorovaKt_41_20.Interfaces.StudentsInterfaces
{
    public interface IStudentService
    {
        public Task<Student[]> GetStudentsAsync(CancellationToken cancellationToken);
    }

    public class StudentService: IStudentService
    {
        public readonly RecordsContext _dbContext;
        public StudentService(RecordsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Student[]> GetStudentsAsync(CancellationToken cancellationToken = default)
        {
            var students = _dbContext.Set<Student>().ToArrayAsync(cancellationToken);
            return students;
        }
    }
}
