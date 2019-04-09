using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentExercisesMVC.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 3)]
        public string Slack { get; set; }

        public string InstructorType { get; set; }

        // Foreign key integer
        public int CohortId { get; set; }

        // This property is for storing the C# object representing the cohort
        public Cohort Cohort { get; set; }
    }
}
