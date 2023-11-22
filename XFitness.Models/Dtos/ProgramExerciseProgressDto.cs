namespace XFitness.Models.Dtos
{
    public class ProgramExerciseProgressDto
    {
        public int ProgramExerciseProgressId { get; set; }
        public int ExerciseId { get; set; }
        public int Sets { get; set; }
        public int Repetitions { get; set; }
        public int Weight { get; set; }
        public DateTime ExerciseProgramDate { get; set; }
    }
}
