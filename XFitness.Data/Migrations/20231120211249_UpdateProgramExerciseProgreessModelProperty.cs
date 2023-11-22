﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XFitness.Data.Migrations
{
    public partial class UpdateProgramExerciseProgreessModelProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "ProgramExercisesProgresses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "ProgramExercisesProgresses");
        }
    }
}
