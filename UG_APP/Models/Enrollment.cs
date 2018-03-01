using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UG_APP.Models
{
    public enum Grade
    {
        dwa, trzy, cztery, pięć
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [Display(Name = "Ocena")]
        [DisplayFormat(NullDisplayText = "Brak oceny")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
