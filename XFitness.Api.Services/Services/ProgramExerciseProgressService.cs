using static XFitness.Shared.Constants.Consts;
using XFitness.Data.Data;
using XFitness.Models.Entities;
using XFitness.Models.Payloads;
using XFitness.Shared.Services.Contracts;
using XFitness.Api.Services.Services.Contracts;
using XFitness.Repositories.Repositories.Contracts;

namespace XFitness.Api.Services.Services
{
    public class ProgramExerciseProgressService : IProgramExerciseProgressService
    {
        private readonly IProgramExerciseProgressRepository _programExerciseProgressRepository;
        public ProgramExerciseProgressService(IProgramExerciseProgressRepository programExerciseProgressRepository)
        {
            _programExerciseProgressRepository = programExerciseProgressRepository;
        }

        public async Task<IEnumerable<ProgramExerciseProgressModel>> GetProgramExerciseProgressList()
        {
            var programExerciseProgressList = await _programExerciseProgressRepository.GetProgramExerciseProgressList();
            return programExerciseProgressList;
        }

        public async Task<ProgramExerciseProgressModel> GetProgramExerciseProgress(int id)
        {
            var programExerciseProgress = await _programExerciseProgressRepository.GetProgramExerciseProgress(id);
            return programExerciseProgress;
        }

        public async Task<ProgramExerciseProgressModel> UpdateProgramExerciseProgress(int id, ProgramExerciseProgressPayload programExerciseProgressPayload)
        {
            var programExerciseProgress = await _programExerciseProgressRepository.UpdateProgramExerciseProgress(id, programExerciseProgressPayload);
            return programExerciseProgress;
        }

        public async Task DeleteProgramExerciseProgress(int id)
        {
            await _programExerciseProgressRepository.DeleteProgramExerciseProgress(id);
        }

        public async Task<ProgramExerciseProgressModel> CreateProgramExerciseProgress(ProgramExerciseProgressPayload programExerciseProgressPayload)
        {
            var programExerciseProgress = await _programExerciseProgressRepository.CreateProgramExerciseProgress(programExerciseProgressPayload);
            return programExerciseProgress;
        }
    }
}
