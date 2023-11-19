using XFitness.Api.Services.Services.Contracts;
using XFitness.Models.Entities;
using XFitness.Models.Payloads;
using XFitness.Repositories.Repositories.Contracts;

namespace XFitness.Api.Services.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;
        public ExerciseService(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }

        public async Task<ExerciseModel> GetExerciseByIdAsync(int id)
        {
            var exercise = await _exerciseRepository.GetExerciseByIdAsync(id);
            return exercise;
        }

        public async Task<ExerciseModel> CreateExercideAsync(ExercisePayload exercisePayload)
        {
            var exercise = await _exerciseRepository.CreateExerciseAsync(exercisePayload);
            return exercise;
        }

        public async Task<ExerciseModel> UpdateExercise(int id, ExercisePayload exercisePayload)
        {
            var exercise = await _exerciseRepository.UpdateExercise(id, exercisePayload);
            return exercise;
        }

        public async Task DeleteExerciseAsync(int id)
        {
            await _exerciseRepository.DeleteExerciseAsync(id);
        }
    }
}
