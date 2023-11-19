using Microsoft.EntityFrameworkCore;
using XFitness.Data.Data;
using XFitness.Models.Entities;
using XFitness.Models.Payloads;
using XFitness.Repositories.Repositories.Contracts;

namespace XFitness.Repositories.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly XFitnessDbContext _context;
        public ExerciseRepository(XFitnessDbContext context)
        {
             _context = context;
        }

        public async Task<ExerciseModel> GetExerciseByIdAsync(int id)
        {
            try
            {
                var exercise = await _context.Exercises.FirstOrDefaultAsync(e => e.ExerciseId == id);
                return exercise;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ExerciseModel> CreateExerciseAsync(ExercisePayload exercisePayload)
        {
            try
            {
                var exerciseModel = new ExerciseModel
                {
                    ExerciseName = exercisePayload.ExerciseName,
                    ExerciseCreatedDate = DateTime.Now,
                    ExerciseDescription = exercisePayload.ExerciseDescription,
                    ImageUrl = exercisePayload.ImageUrl,
                    Category = exercisePayload.Category,
                };

                await _context.Exercises.AddAsync(exerciseModel);
                await _context.SaveChangesAsync();

                return exerciseModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ExerciseModel> UpdateExercise(int id, ExercisePayload exercisePayload)
        {
            try
            {
                var exerciseModel = await _context.Exercises.FirstOrDefaultAsync(e => e.ExerciseId == id);

                exerciseModel.ExerciseDescription = exercisePayload.ExerciseDescription;
                exerciseModel.ExerciseName = exercisePayload.ExerciseName;
                exerciseModel.Category = exercisePayload.Category;
                exerciseModel.ImageUrl = exercisePayload.ImageUrl;

                await _context.SaveChangesAsync();
                return exerciseModel;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteExerciseAsync(int id)
        {
            try
            {
                var exerciseModel = await _context.Exercises.FirstOrDefaultAsync(e => e.ExerciseId == id);
                _context.Exercises.Remove(exerciseModel);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
