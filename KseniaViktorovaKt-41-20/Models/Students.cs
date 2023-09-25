namespace KseniaViktorovaKt_41_20.Models
{
    public class Students
    {
        public string NumberGradebook { get; set; }
        public int? IdGroup { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public Groups? Group {  get; set; }  
        public ICollection<RecordsSession>? RecordsSession { get; set; }
        public ICollection<RecordsSemester>? RecordsSemester { get; set; }
    }
}
