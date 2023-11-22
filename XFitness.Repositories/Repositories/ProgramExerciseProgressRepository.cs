using Microsoft.EntityFrameworkCore;
using XFitness.Data.Data;
using XFitness.Models.Entities;
using XFitness.Models.Payloads;
using XFitness.Repositories.Repositories.Contracts;
using XFitness.Shared.Services.Contracts;
using static XFitness.Shared.Constants.Consts;

namespace XFitness.Repositories.Repositories
{
    public class ProgramExerciseProgressRepository : IProgramExerciseProgressRepository
    {
        private readonly XFitnessDbContext _context;
        private readonly ILoggerToFile _logger;
        public ProgramExerciseProgressRepository(XFitnessDbContext context, ILoggerToFile logger)
        {
             _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<ProgramExerciseProgressModel>> GetProgramExerciseProgressList()
        {
            try
            {
                var programExerciseProgressList = await _context.ProgramExercisesProgresses.ToListAsync();
                return programExerciseProgressList;
            }
            catch (Exception ex)
            {
                _logger.LogToFile(ex.ToString(), FilePaths.ProgramExerciseProgressPath);
                throw;
            }
        }

        public async Task<ProgramExerciseProgressModel> GetProgramExerciseProgress(int id)
        {
            try
            {
                var programExerciseProgress = await _context.ProgramExercisesProgresses.FirstOrDefaultAsync(e => e.ProgramExerciseProgressId == id);
                return programExerciseProgress;
            }
            catch (Exception ex)
            {
                _logger.LogToFile(ex.ToString(), FilePaths.ProgramExerciseProgressPath);
                throw;
            }
        }

        public async Task<ProgramExerciseProgressModel> UpdateProgramExerciseProgress(int id, ProgramExerciseProgressPayload programExerciseProgressPayload)
        {
            try
            {
                var programExerciseProgress = await _context.ProgramExercisesProgresses.FirstOrDefaultAsync(e => e.ProgramExerciseProgressId == id);
                programExerciseProgress.Sets = programExerciseProgressPayload.Sets;
                programExerciseProgress.Repetitions = programExerciseProgressPayload.Repetitions;
                programExerciseProgress.Weight = programExerciseProgressPayload.Weight;
                programExerciseProgress.ExerciseId = programExerciseProgressPayload.ExerciseId;

                await _context.SaveChangesAsync();
                return programExerciseProgress;
            }
            catch (Exception ex)
            {
                _logger.LogToFile(ex.ToString(), FilePaths.ProgramExerciseProgressPath);
                throw;
            }
        }

        public async Task DeleteProgramExerciseProgress(int id)
        {
            try
            {
                var programExerciseProgress = await _context.ProgramExercisesProgresses.FirstOrDefaultAsync(e => e.ProgramExerciseProgressId == id);

                _context.ProgramExercisesProgresses.Remove(programExerciseProgress);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogToFile(ex.ToString(), FilePaths.ProgramExerciseProgressPath);
                throw;
            }
        }

        public async Task<ProgramExerciseProgressModel> CreateProgramExerciseProgress(ProgramExerciseProgressPayload programExerciseProgressPayload)
        {
            try
            {
                var programExerciseProgressModel = new ProgramExerciseProgressModel
                {
                    ExerciseProgramDate = DateTime.Now,
                    Sets = programExerciseProgressPayload.Sets,
                    Repetitions = programExerciseProgressPayload.Repetitions,
                    Weight = programExerciseProgressPayload.Weight,
                    ExerciseId = programExerciseProgressPayload.ExerciseId,
                };

                await _context.ProgramExercisesProgresses.AddAsync(programExerciseProgressModel);
                await _context.SaveChangesAsync();

                return programExerciseProgressModel;
            }
            catch (Exception ex)
            {
                _logger.LogToFile(ex.ToString(), FilePaths.ProgramExerciseProgressPath);
                throw;
            }
        }
    }
}
