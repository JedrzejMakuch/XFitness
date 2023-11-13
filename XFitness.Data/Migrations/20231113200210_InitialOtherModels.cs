using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XFitness.Data.Migrations
{
    public partial class InitialOtherModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserExerciseProgramModel",
                columns: table => new
                {
                    UserExerciseProgramId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModelUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserExerciseProgramModel", x => x.UserExerciseProgramId);
                    table.ForeignKey(
                        name: "FK_UserExerciseProgramModel_Users_UserModelUserId",
                        column: x => x.UserModelUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UserPsychicalParametersModel",
                columns: table => new
                {
                    UserPsychicalParametersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    UserModelUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPsychicalParametersModel", x => x.UserPsychicalParametersId);
                    table.ForeignKey(
                        name: "FK_UserPsychicalParametersModel_Users_UserModelUserId",
                        column: x => x.UserModelUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ExerciseModel",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserExerciseProgramModelUserExerciseProgramId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseModel", x => x.ExerciseId);
                    table.ForeignKey(
                        name: "FK_ExerciseModel_UserExerciseProgramModel_UserExerciseProgramModelUserExerciseProgramId",
                        column: x => x.UserExerciseProgramModelUserExerciseProgramId,
                        principalTable: "UserExerciseProgramModel",
                        principalColumn: "UserExerciseProgramId");
                });

            migrationBuilder.CreateTable(
                name: "ProgramExerciseProgressModel",
                columns: table => new
                {
                    ProgramExerciseProgressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    EverciseProgramDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Repetitions = table.Column<int>(type: "int", nullable: false),
                    UserExerciseProgramModelUserExerciseProgramId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramExerciseProgressModel", x => x.ProgramExerciseProgressId);
                    table.ForeignKey(
                        name: "FK_ProgramExerciseProgressModel_UserExerciseProgramModel_UserExerciseProgramModelUserExerciseProgramId",
                        column: x => x.UserExerciseProgramModelUserExerciseProgramId,
                        principalTable: "UserExerciseProgramModel",
                        principalColumn: "UserExerciseProgramId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseModel_UserExerciseProgramModelUserExerciseProgramId",
                table: "ExerciseModel",
                column: "UserExerciseProgramModelUserExerciseProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramExerciseProgressModel_UserExerciseProgramModelUserExerciseProgramId",
                table: "ProgramExerciseProgressModel",
                column: "UserExerciseProgramModelUserExerciseProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExerciseProgramModel_UserModelUserId",
                table: "UserExerciseProgramModel",
                column: "UserModelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPsychicalParametersModel_UserModelUserId",
                table: "UserPsychicalParametersModel",
                column: "UserModelUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseModel");

            migrationBuilder.DropTable(
                name: "ProgramExerciseProgressModel");

            migrationBuilder.DropTable(
                name: "UserPsychicalParametersModel");

            migrationBuilder.DropTable(
                name: "UserExerciseProgramModel");
        }
    }
}
