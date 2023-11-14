namespace XFitness.Models.Payloads
{
    public class ExercisePayload
    {
        public string ExerciseName { get; set; }
        public string ExerciseDescription { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public DateTime ExerciseCreatedDate { get; set; }
    }
}
