using XFitness.Models.Entities;
using XFitness.Models.Payloads;

namespace XFitness.Repositories.Repositories.Contracts
{
    public interface IProgramExerciseProgressRepository
    {
        Task<IEnumerable<ProgramExerciseProgressModel>> GetProgramExerciseProgressList();
        Task<ProgramExerciseProgressModel> GetProgramExerciseProgress(int id);
        Task<ProgramExerciseProgressModel> UpdateProgramExerciseProgress(int id, ProgramExerciseProgressPayload programExerciseProgressPayload);
        Task DeleteProgramExerciseProgress(int id);
        Task<ProgramExerciseProgressModel> CreateProgramExerciseProgress(ProgramExerciseProgressPayload programExerciseProgressPayload);
    }
}
