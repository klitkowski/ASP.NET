using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UG_APP.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Numer")]
        [Required(ErrorMessage = "Numer jest wymagany.")]
        public int CourseID { get; set; }
        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Nazwa jest wymagana.")]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}