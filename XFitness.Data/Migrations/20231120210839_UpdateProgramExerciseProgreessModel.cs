using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XFitness.Data.Migrations
{
    public partial class UpdateProgramExerciseProgreessModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EverciseProgramDate",
                table: "ProgramExercisesProgresses",
                newName: "ExerciseProgramDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExerciseProgramDate",
                table: "ProgramExercisesProgresses",
                newName: "EverciseProgramDate");
        }
    }
}
