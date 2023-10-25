using System.ComponentModel.DataAnnotations;

namespace KseniaViktorovaKt_41_20.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
