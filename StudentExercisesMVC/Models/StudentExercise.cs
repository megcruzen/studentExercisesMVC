using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercisesMVC.Models
{
    public class StudentExercise
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExerciseId { get; set; }
        
        public Student Student { get; set; }
        public Exercise Exercise { get; set; }
    }
}
