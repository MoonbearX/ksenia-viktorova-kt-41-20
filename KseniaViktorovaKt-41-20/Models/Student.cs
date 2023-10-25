using System.ComponentModel.DataAnnotations;

namespace KseniaViktorovaKt_41_20.Models
{
    public class Student
    {
        //public string NumberGradebook { get; set; }
        [Key]
        public int Id { get; set; }
        public int? IdGroup { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public Group? Group {  get; set; }  
        //public ICollection<RecordSession>? RecordsSession { get; set; }
        //public ICollection<RecordSemester>? RecordsSemester { get; set; }
    }
}
