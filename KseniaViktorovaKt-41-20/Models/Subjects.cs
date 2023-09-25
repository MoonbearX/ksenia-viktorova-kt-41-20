namespace KseniaViktorovaKt_41_20.Models
{
    public class Subjects
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int IdGroup { get; set; }
        public Groups? Group {  get; set; }
        public ICollection<RecordsSession>? RecordsSession { get; set; }
        public ICollection<RecordsSemester>? RecordsSemester { get; set; }
    }
}
