using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UG_APP.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        [StringLength(50, ErrorMessage = "Nazwisko nie może być dłuższe niż 50 znaków.")]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane.")]
        [StringLength(50, ErrorMessage = "Imię nie może być dłuższe niż 50 znaków.")]
        [Column("FirstName")]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data rejestracji")]
        [Required(ErrorMessage = "Data jest wymagana.")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Pełne imię i nazwisko")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        [Display(Name = "Zapisany")]
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
