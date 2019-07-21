using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// dog graduating date and info
namespace LuckyPaw.Models
{
    public class Graduates
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
