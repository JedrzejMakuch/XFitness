using System.ComponentModel.DataAnnotations;

namespace XFitness.Models.Entities
{
    public class UserExerciseProgramModel
    {
        [Key]
        public int UserExerciseProgramId { get; set; }
        public DateTime ProgramCreatedDate { get; set; }
        public List<ExerciseModel> Exercises { get; set; }
        public List<ProgramExerciseProgressModel> ProgramExerciseProgresses { get; set; }
    }
}
