using System.ComponentModel.DataAnnotations;
namespace XFitness.Models.Entities
{
    public class UserPsychicalParametersModel
    {
        [Key]
        public int UserPsychicalParametersId { get; set; }
        public DateTime CreatedOn { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
    }
}
