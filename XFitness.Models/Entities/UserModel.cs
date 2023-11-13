using System.ComponentModel.DataAnnotations;

namespace XFitness.Models.Entities
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime UserCreatedDate { get; set; }
        public List<UserPsychicalParametersModel> PsychicalParameters { get; set; }
        public List<UserExerciseProgramModel> ExercisePrograms { get; set; }
    }
}
