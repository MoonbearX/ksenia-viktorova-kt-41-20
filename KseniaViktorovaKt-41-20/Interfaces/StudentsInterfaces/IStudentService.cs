using KseniaViktorovaKt_41_20.Data;
using KseniaViktorovaKt_41_20.Models;
using Microsoft.EntityFrameworkCore;


namespace KseniaViktorovaKt_41_20.Interfaces.StudentsInterfaces
{
    public interface IStudentService
    {
        public Task<Student[]> GetStudentsAsync(CancellationToken cancellationToken);
        public Task<Student> GetStudentAsync(int id, CancellationToken cancellationToken);
        public Task AddStudentAsync(Student student, CancellationToken cancellationToken);
        public Task UpdateStudentAsync(Student student, CancellationToken cancellationToken);
        public Task DeleteStudentAsync(Student student, CancellationToken cancellationToken);
    }

    public class StudentService: IStudentService
    {
        public readonly RecordsContext _dbContext;
        public StudentService(RecordsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Student[]> GetStudentsAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Students.ToArrayAsync();
        }

        public async Task<Student> GetStudentAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Students.FindAsync(id);
        }

        public async Task AddStudentAsync(Student student, CancellationToken cancellationToken = default)
        {
            var group = await _dbContext.Groups.FindAsync(student.IdGroup);
            student.Group = group;

            _dbContext.Students.Add(student);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateStudentAsync(Student student, CancellationToken cancellationToken = default)
        {
            var group = await _dbContext.Groups.FindAsync(student.IdGroup);
            student.Group = group;

            _dbContext.Students.Update(student);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteStudentAsync(Student student, CancellationToken cancellationToken = default)
        {
            _dbContext.Students.Remove(student);
            await _dbContext.SaveChangesAsync();
        }

    }
}
