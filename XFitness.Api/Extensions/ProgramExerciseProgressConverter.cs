using XFitness.Models.Dtos;
using XFitness.Models.Entities;

namespace XFitness.Api.Extensions
{
    public static class ProgramExerciseProgressConverter
    {
        public static IEnumerable<ProgramExerciseProgressDto> ConverterToDto(this IEnumerable<ProgramExerciseProgressModel> programExerciseProgressModels)
        {
            var programExerciseProgressDtos = programExerciseProgressModels.Select(programExerciseProgressModel => new ProgramExerciseProgressDto
            {
                ExerciseId = programExerciseProgressModel.ExerciseId,
                Weight = programExerciseProgressModel.Weight,
                Sets = programExerciseProgressModel.Sets,
                ProgramExerciseProgressId = programExerciseProgressModel.ProgramExerciseProgressId,
                Repetitions = programExerciseProgressModel.Repetitions,
                ExerciseProgramDate = programExerciseProgressModel.ExerciseProgramDate,
            }).ToList();

            return programExerciseProgressDtos;
        }
    }
}
