namespace KseniaViktorovaKt_41_20.Models
{
    public class Groups
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Students>? Student { get; set; }
        public ICollection<Subjects>? Subject { get; set; }
        public ICollection<RecordsSession>? RecordsSession { get; set; }
        public ICollection<RecordsSemester>? RecordsSemester { get; set; }
    }
}
