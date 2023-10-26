using KseniaViktorovaKt_41_20.Data;
using KseniaViktorovaKt_41_20.Interfaces.StudentsInterfaces;
using KseniaViktorovaKt_41_20.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLog.Config;
using NLog.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KseniaViktorovaKt_41_20.Tests
{
    public class StudentIntegrationTests
    {
        public readonly DbContextOptions<RecordsContext> _dbContextOptions;

        public StudentIntegrationTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<RecordsContext>()
                .UseInMemoryDatabase(databaseName: "test_db")
                .Options;
        }

        [Fact]
        public async Task GetStudentsAsync_AllStudents()
        {
            // Arrange
            var ctx = new RecordsContext(_dbContextOptions);
            var studentService = new StudentService(ctx);
            var groups = new List<Group>
            {
                new Group
                {
                    Name = "KT-41-20"
                },
                new Group
                {
                    Name = "KT-42-20"
                }
            };
            await ctx.Set<Group>().AddRangeAsync(groups);

            var students = new List<Student>
            {
                new Student
                {
                   Name = "Николай",
                    Surname = "Бакин",
                    Patronymic = "Сергеевич",
                    DateBirth = new DateTime(2001,12,10),
                    Email="nik@mail.ru",
                    Phone= "+7(575)462-77-27",
                    IdGroup=1
                },
                new Student
                {
                    Name = "Виктория",
                    Surname = "Иванов",
                    Patronymic = "Алексеевич",
                    DateBirth = new DateTime(2002, 03, 12),
                    Email = "vik@mail.ru",
                    Phone = "+7(575)462-78-23",
                    IdGroup = 1
                },
                new Student
                {
                    Name = "Анна",
                    Surname = "Маркова",
                    Patronymic = "Алексеевна",
                    DateBirth = new DateTime(2002, 05, 22),
                    Email = "ann@mail.ru",
                    Phone = "+7(575)457-78-23",
                    IdGroup = 2
                }
            };
            await ctx.Set<Student>().AddRangeAsync(students);

            await ctx.SaveChangesAsync();

            // Act
            var studentsResult = await studentService.GetStudentsAsync(CancellationToken.None);

            // Assert
            Assert.Equal(3, studentsResult.Length);
        }

        [Fact]
        public async Task GetStudentAsync_Id_Student()
        {
            // Arrange
            var ctx = new RecordsContext(_dbContextOptions);
            var studentService = new StudentService(ctx);
            var groups = new List<Group>
            {
                new Group
                {
                    Name = "KT-41-20"
                }
            };
            await ctx.Set<Group>().AddRangeAsync(groups);

            var student = new Student
            {
                Name = "Николай",
                Surname = "Бакин",
                Patronymic = "Сергеевич",
                DateBirth = new DateTime(2001, 12, 10),
                Email = "nik@mail.ru",
                Phone = "+7(575)462-77-27",
                IdGroup = 1
            };
            await ctx.Set<Student>().AddAsync(student);
            await ctx.SaveChangesAsync();

            // Act
            var studentResult = await studentService.GetStudentAsync(student.Id, CancellationToken.None);

            // Assert
            Assert.Equal(student.Id, studentResult.Id);
            Assert.Equal(student.Name, studentResult.Name);
            Assert.Equal(student.Surname, studentResult.Surname);
            Assert.Equal(student.Patronymic, studentResult.Patronymic);
            Assert.Equal(student.DateBirth, studentResult.DateBirth);
            Assert.Equal(student.Email, studentResult.Email);
            Assert.Equal(student.Phone, studentResult.Phone);
            Assert.Equal(student.IdGroup, studentResult.IdGroup);
        }

        [Fact]
        public async Task AddStudentAsync_AddsStudent()
        {
            // Arrange
            var ctx = new RecordsContext(_dbContextOptions);
            var studentService = new StudentService(ctx);

            var group = new Group
            {
                Name = "KT-41-20"
            };
            await ctx.Set<Group>().AddAsync(group);
            await ctx.SaveChangesAsync();

            var student = new Student
            {
                Name = "Александр",
                Surname = "Смирнов",
                Patronymic = "Иванович",
                DateBirth = new DateTime(2003, 01, 25),
                Email = "alex@mail.ru",
                Phone = "+7(575)462-79-55",
                IdGroup = group.Id
            };

            // Act
            await studentService.AddStudentAsync(student);

            // Assert
            var addedStudent = await ctx.Set<Student>().SingleOrDefaultAsync(s => s.Name == "Александр" && s.Surname == "Смирнов");
            Assert.NotNull(addedStudent);
            Assert.Equal("Иванович", addedStudent.Patronymic);
            Assert.Equal(new DateTime(2003, 01, 25), addedStudent.DateBirth);
            Assert.Equal("alex@mail.ru", addedStudent.Email);
            Assert.Equal("+7(575)462-79-55", addedStudent.Phone);
            Assert.Equal(group.Id, addedStudent.IdGroup);
        }

        [Fact]
        public async Task DeleteStudentAsync_Id_Student()
        {
            // Arrange
            var ctx = new RecordsContext(_dbContextOptions);
            var studentService = new StudentService(ctx);
            var groups = new List<Group>
            {
                new Group
                {
                    Name = "KT-41-20"
                },
                new Group
                {
                    Name = "KT-42-20"
                }
            };
            await ctx.Set<Group>().AddRangeAsync(groups);

            var students = new List<Student>
            {
                new Student
                {
                    Name = "Николай",
                    Surname = "Бакин",
                    Patronymic = "Сергеевич",
                    DateBirth = new DateTime(2001,12,10),
                    Email="nik@mail.ru",
                    Phone= "+7(575)462-77-27",
                    IdGroup=1
                },
                new Student
                {
                    Name = "Виктория",
                    Surname = "Иванов",
                    Patronymic = "Алексеевич",
                    DateBirth = new DateTime(2002, 03, 12),
                    Email = "vik@mail.ru",
                    Phone = "+7(575)462-78-23",
                    IdGroup = 1
                },
                new Student
                {
                    Name = "Анна",
                    Surname = "Маркова",
                    Patronymic = "Алексеевна",
                    DateBirth = new DateTime(2002, 05, 22),
                    Email = "ann@mail.ru",
                    Phone = "+7(575)457-78-23",
                    IdGroup = 2
                }
            };
            await ctx.Set<Student>().AddRangeAsync(students);

            await ctx.SaveChangesAsync();

            // Act
            var studentIdToDelete = 1; // ID of the student to delete
            var studentResult = await studentService.GetStudentAsync(studentIdToDelete, CancellationToken.None);
            await studentService.DeleteStudentAsync(studentResult, CancellationToken.None);

            var studentsResult = await studentService.GetStudentsAsync(CancellationToken.None);

            // Assert
            Assert.Equal(2, studentsResult.Length);
            Assert.DoesNotContain(studentsResult, s => s.Id == studentIdToDelete);
        }

        [Fact]
        public async Task UpdateStudentAsync_Id_Student()
        {
            // Arrange
            var ctx = new RecordsContext(_dbContextOptions);
            var studentService = new StudentService(ctx);
            var student = new Student
            {
                Name = "Николай",
                Surname = "Бакин",
                Patronymic = "Сергеевич",
                DateBirth = new DateTime(2001, 12, 10),
                Email = "nik@mail.ru",
                Phone = "+7(575)462-77-27",
                IdGroup = 1
            };
            await ctx.Set<Student>().AddAsync(student);
            await ctx.SaveChangesAsync();

            // Act
            student.Name = "Никита";
            student.Surname = "Бакин";
            student.Patronymic = "Сергеевич";
            student.DateBirth = new DateTime(2001, 12, 10);
            student.Email = "nik@mail.ru";
            student.Phone = "+7(575)462-77-27";
            student.IdGroup = 1;
            await studentService.UpdateStudentAsync(student, CancellationToken.None);

            // Assert
            Assert.Equal("Никита", student.Name);
        }
    }
}
