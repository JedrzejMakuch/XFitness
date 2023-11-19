using XFitness.Models.Entities;
using XFitness.Models.Payloads;

namespace XFitness.Api.Services.Services.Contracts
{
    public interface IExerciseService
    {
        Task<ExerciseModel> GetExerciseByIdAsync(int id);
        Task<ExerciseModel> CreateExercideAsync(ExercisePayload exercisePayload);
        Task<ExerciseModel> UpdateExercise(int id, ExercisePayload exercisePayload);
        Task DeleteExerciseAsync(int id);
    }
}
