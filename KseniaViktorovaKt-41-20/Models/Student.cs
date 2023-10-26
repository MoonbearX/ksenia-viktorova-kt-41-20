using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace KseniaViktorovaKt_41_20.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public int? IdGroup { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public DateTime? DateBirth { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Group? Group {  get; set; }
    }
}
