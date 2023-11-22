using XFitness.Models.Entities;
using XFitness.Models.Payloads;

namespace XFitness.Api.Services.Services.Contracts
{
    public interface IProgramExerciseProgressService
    {
        Task<IEnumerable<ProgramExerciseProgressModel>> GetProgramExerciseProgressList();
        Task<ProgramExerciseProgressModel> GetProgramExerciseProgress(int id);
        Task<ProgramExerciseProgressModel> UpdateProgramExerciseProgress(int id, ProgramExerciseProgressPayload programExerciseProgressPayload);
        Task DeleteProgramExerciseProgress(int id);
        Task<ProgramExerciseProgressModel> CreateProgramExerciseProgress(ProgramExerciseProgressPayload programExerciseProgressPayload);
    }
}
