using XFitness.Models.Entities;
using XFitness.Models.Payloads;

namespace XFitness.Repositories.Repositories.Contracts
{
    public interface IExerciseRepository
    {
        Task<ExerciseModel> GetExerciseByIdAsync(int id);
        Task<ExerciseModel> CreateExerciseAsync(ExercisePayload exercisePayload);
        Task<ExerciseModel> UpdateExercise(int id, ExercisePayload exercisePayload);
        Task DeleteExerciseAsync(int id);
    }
}
