using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentExercisesMVC.Models
{
    public class Cohort
    {
        public int Id { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 5)]
        public string CohortName { get; set; }

        public Instructor LeadInstructor { get; set; }
        public List<Student> StudentList { get; set; } = new List<Student>();
        public List<Instructor> InstructorList { get; set; } = new List<Instructor>();
    }
}
