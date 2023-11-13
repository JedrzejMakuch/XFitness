using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XFitness.Data.Migrations
{
    public partial class InitialOtherModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseModel_UserExerciseProgramModel_UserExerciseProgramModelUserExerciseProgramId",
                table: "ExerciseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramExerciseProgressModel_UserExerciseProgramModel_UserExerciseProgramModelUserExerciseProgramId",
                table: "ProgramExerciseProgressModel");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExerciseProgramModel_Users_UserModelUserId",
                table: "UserExerciseProgramModel");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPsychicalParametersModel_Users_UserModelUserId",
                table: "UserPsychicalParametersModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPsychicalParametersModel",
                table: "UserPsychicalParametersModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserExerciseProgramModel",
                table: "UserExerciseProgramModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgramExerciseProgressModel",
                table: "ProgramExerciseProgressModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseModel",
                table: "ExerciseModel");

            migrationBuilder.RenameTable(
                name: "UserPsychicalParametersModel",
                newName: "UserPsychicalParameters");

            migrationBuilder.RenameTable(
                name: "UserExerciseProgramModel",
                newName: "UserExercisePrograms");

            migrationBuilder.RenameTable(
                name: "ProgramExerciseProgressModel",
                newName: "ProgramExercisesProgresses");

            migrationBuilder.RenameTable(
                name: "ExerciseModel",
                newName: "Exercises");

            migrationBuilder.RenameIndex(
                name: "IX_UserPsychicalParametersModel_UserModelUserId",
                table: "UserPsychicalParameters",
                newName: "IX_UserPsychicalParameters_UserModelUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserExerciseProgramModel_UserModelUserId",
                table: "UserExercisePrograms",
                newName: "IX_UserExercisePrograms_UserModelUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgramExerciseProgressModel_UserExerciseProgramModelUserExerciseProgramId",
                table: "ProgramExercisesProgresses",
                newName: "IX_ProgramExercisesProgresses_UserExerciseProgramModelUserExerciseProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseModel_UserExerciseProgramModelUserExerciseProgramId",
                table: "Exercises",
                newName: "IX_Exercises_UserExerciseProgramModelUserExerciseProgramId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPsychicalParameters",
                table: "UserPsychicalParameters",
                column: "UserPsychicalParametersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserExercisePrograms",
                table: "UserExercisePrograms",
                column: "UserExerciseProgramId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgramExercisesProgresses",
                table: "ProgramExercisesProgresses",
                column: "ProgramExerciseProgressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exercises",
                table: "Exercises",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_UserExercisePrograms_UserExerciseProgramModelUserExerciseProgramId",
                table: "Exercises",
                column: "UserExerciseProgramModelUserExerciseProgramId",
                principalTable: "UserExercisePrograms",
                principalColumn: "UserExerciseProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramExercisesProgresses_UserExercisePrograms_UserExerciseProgramModelUserExerciseProgramId",
                table: "ProgramExercisesProgresses",
                column: "UserExerciseProgramModelUserExerciseProgramId",
                principalTable: "UserExercisePrograms",
                principalColumn: "UserExerciseProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserExercisePrograms_Users_UserModelUserId",
                table: "UserExercisePrograms",
                column: "UserModelUserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPsychicalParameters_Users_UserModelUserId",
                table: "UserPsychicalParameters",
                column: "UserModelUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_UserExercisePrograms_UserExerciseProgramModelUserExerciseProgramId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramExercisesProgresses_UserExercisePrograms_UserExerciseProgramModelUserExerciseProgramId",
                table: "ProgramExercisesProgresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExercisePrograms_Users_UserModelUserId",
                table: "UserExercisePrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPsychicalParameters_Users_UserModelUserId",
                table: "UserPsychicalParameters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPsychicalParameters",
                table: "UserPsychicalParameters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserExercisePrograms",
                table: "UserExercisePrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgramExercisesProgresses",
                table: "ProgramExercisesProgresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exercises",
                table: "Exercises");

            migrationBuilder.RenameTable(
                name: "UserPsychicalParameters",
                newName: "UserPsychicalParametersModel");

            migrationBuilder.RenameTable(
                name: "UserExercisePrograms",
                newName: "UserExerciseProgramModel");

            migrationBuilder.RenameTable(
                name: "ProgramExercisesProgresses",
                newName: "ProgramExerciseProgressModel");

            migrationBuilder.RenameTable(
                name: "Exercises",
                newName: "ExerciseModel");

            migrationBuilder.RenameIndex(
                name: "IX_UserPsychicalParameters_UserModelUserId",
                table: "UserPsychicalParametersModel",
                newName: "IX_UserPsychicalParametersModel_UserModelUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserExercisePrograms_UserModelUserId",
                table: "UserExerciseProgramModel",
                newName: "IX_UserExerciseProgramModel_UserModelUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgramExercisesProgresses_UserExerciseProgramModelUserExerciseProgramId",
                table: "ProgramExerciseProgressModel",
                newName: "IX_ProgramExerciseProgressModel_UserExerciseProgramModelUserExerciseProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_Exercises_UserExerciseProgramModelUserExerciseProgramId",
                table: "ExerciseModel",
                newName: "IX_ExerciseModel_UserExerciseProgramModelUserExerciseProgramId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPsychicalParametersModel",
                table: "UserPsychicalParametersModel",
                column: "UserPsychicalParametersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserExerciseProgramModel",
                table: "UserExerciseProgramModel",
                column: "UserExerciseProgramId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgramExerciseProgressModel",
                table: "ProgramExerciseProgressModel",
                column: "ProgramExerciseProgressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseModel",
                table: "ExerciseModel",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseModel_UserExerciseProgramModel_UserExerciseProgramModelUserExerciseProgramId",
                table: "ExerciseModel",
                column: "UserExerciseProgramModelUserExerciseProgramId",
                principalTable: "UserExerciseProgramModel",
                principalColumn: "UserExerciseProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramExerciseProgressModel_UserExerciseProgramModel_UserExerciseProgramModelUserExerciseProgramId",
                table: "ProgramExerciseProgressModel",
                column: "UserExerciseProgramModelUserExerciseProgramId",
                principalTable: "UserExerciseProgramModel",
                principalColumn: "UserExerciseProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserExerciseProgramModel_Users_UserModelUserId",
                table: "UserExerciseProgramModel",
                column: "UserModelUserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPsychicalParametersModel_Users_UserModelUserId",
                table: "UserPsychicalParametersModel",
                column: "UserModelUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
