using System.ComponentModel.DataAnnotations.Schema;

namespace LuckyPaw.Models
{
    public class Services
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public System.Collections.Generic.ICollection<Enrollment> Enrollments { get; set; }
    }
}