namespace XFitness.Models.Payloads
{
    public class ProgramExerciseProgressPayload
    {
        public int ExerciseId { get; set; }
        public int Sets { get; set; }
        public int Repetitions { get; set; }
        public int Weight { get; set; }
    }
}
