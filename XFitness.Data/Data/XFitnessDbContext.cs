using Microsoft.EntityFrameworkCore;
using XFitness.Models.Entities;

namespace XFitness.Data.Data
{
    public class XFitnessDbContext : DbContext
    {
        public XFitnessDbContext(DbContextOptions<XFitnessDbContext> options)
            : base(options)
        { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<ExerciseModel> Exercises { get; set; }
        public DbSet<ProgramExerciseProgressModel> ProgramExercisesProgresses { get; set; }
        public DbSet<UserPsychicalParametersModel> UserPsychicalParameters { get; set; }
        public DbSet<UserExerciseProgramModel> UserExercisePrograms { get; set; }
    }
}
