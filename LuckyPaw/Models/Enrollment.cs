namespace LuckyPaw.Models

// when does the dog is enroll
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int serviceType { get; set; }
        public int dogId { get; set; }
        

        public Services Course { get; set; }
        public Graduates Student { get; set; }
    }
}