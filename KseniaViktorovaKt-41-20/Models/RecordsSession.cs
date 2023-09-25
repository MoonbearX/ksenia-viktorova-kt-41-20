namespace KseniaViktorovaKt_41_20.Models
{
    public class RecordsSession
    {
        public enum Grades
        {
            Отлично, Хорошо, Удовлетворительно, Зачет, Незачет
        }
        public int Id { get; set; }
        public int NumberStudent { get; set; }
        public int IdSubject { get; set; }
        public int IdGroup { get; set; }
        public Grades Grade { get; set; }
        public DateTime Date { get; set; }  
        public Subjects? Subject { get; set; }
        public Students? Student { get; set; }
        public Groups? Group { get; set; }
    }
}
