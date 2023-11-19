using XFitness.Models.Entities;

namespace XFitness.Api.Extension
{
    public static class ExerciseConverter
    {
        public static ExerciseModel ConvertToDto(this ExerciseModel exercise)
        {
            var exerciseModel = new ExerciseModel
            {
                ExerciseId = exercise.ExerciseId,
                ExerciseCreatedDate = exercise.ExerciseCreatedDate,
                ExerciseDescription = exercise.ExerciseDescription,
                ExerciseName = exercise.ExerciseName,
                Category = exercise.Category,
                ImageUrl = exercise.ImageUrl,
            };

            return exerciseModel;
        }
    }
}
