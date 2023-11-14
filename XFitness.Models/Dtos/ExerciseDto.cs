namespace XFitness.Models.Dtos
{
    public class ExerciseDto
    {
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseDescription { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public DateTime ExerciseCreatedDate { get; set; }
    }
}
