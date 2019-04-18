using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnitecComputing.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [StringLength(50,ErrorMessage ="First name cannot be longer than 50 characters.")]
        [Display(Name ="FirstName")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Full Name")] //Week 4
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
