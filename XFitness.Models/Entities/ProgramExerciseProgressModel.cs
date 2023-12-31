﻿using System.ComponentModel.DataAnnotations;

namespace XFitness.Models.Entities
{
    public class ProgramExerciseProgressModel
    {
        [Key]
        public int ProgramExerciseProgressId { get; set; }
        public int ExerciseId { get; set; }
        public DateTime ExerciseProgramDate { get; set; }
        public int Sets { get; set; }
        public int Repetitions { get; set; }
        public int Weight { get; set; }
    }
}
