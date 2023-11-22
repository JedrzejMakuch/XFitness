﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XFitness.Data.Data;

#nullable disable

namespace XFitness.Data.Migrations
{
    [DbContext(typeof(XFitnessDbContext))]
    [Migration("20231120211249_UpdateProgramExerciseProgreessModelProperty")]
    partial class UpdateProgramExerciseProgreessModelProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("XFitness.Models.Entities.ExerciseModel", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseId"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExerciseCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExerciseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExerciseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserExerciseProgramModelUserExerciseProgramId")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId");

                    b.HasIndex("UserExerciseProgramModelUserExerciseProgramId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("XFitness.Models.Entities.ProgramExerciseProgressModel", b =>
                {
                    b.Property<int>("ProgramExerciseProgressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgramExerciseProgressId"), 1L, 1);

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExerciseProgramDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Repetitions")
                        .HasColumnType("int");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.Property<int?>("UserExerciseProgramModelUserExerciseProgramId")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("ProgramExerciseProgressId");

                    b.HasIndex("UserExerciseProgramModelUserExerciseProgramId");

                    b.ToTable("ProgramExercisesProgresses");
                });

            modelBuilder.Entity("XFitness.Models.Entities.UserExerciseProgramModel", b =>
                {
                    b.Property<int>("UserExerciseProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserExerciseProgramId"), 1L, 1);

                    b.Property<DateTime>("ProgramCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserModelUserId")
                        .HasColumnType("int");

                    b.HasKey("UserExerciseProgramId");

                    b.HasIndex("UserModelUserId");

                    b.ToTable("UserExercisePrograms");
                });

            modelBuilder.Entity("XFitness.Models.Entities.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UserCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("XFitness.Models.Entities.UserPsychicalParametersModel", b =>
                {
                    b.Property<int>("UserPsychicalParametersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserPsychicalParametersId"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<int?>("UserModelUserId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("UserPsychicalParametersId");

                    b.HasIndex("UserModelUserId");

                    b.ToTable("UserPsychicalParameters");
                });

            modelBuilder.Entity("XFitness.Models.Entities.ExerciseModel", b =>
                {
                    b.HasOne("XFitness.Models.Entities.UserExerciseProgramModel", null)
                        .WithMany("Exercises")
                        .HasForeignKey("UserExerciseProgramModelUserExerciseProgramId");
                });

            modelBuilder.Entity("XFitness.Models.Entities.ProgramExerciseProgressModel", b =>
                {
                    b.HasOne("XFitness.Models.Entities.UserExerciseProgramModel", null)
                        .WithMany("ProgramExerciseProgresses")
                        .HasForeignKey("UserExerciseProgramModelUserExerciseProgramId");
                });

            modelBuilder.Entity("XFitness.Models.Entities.UserExerciseProgramModel", b =>
                {
                    b.HasOne("XFitness.Models.Entities.UserModel", null)
                        .WithMany("ExercisePrograms")
                        .HasForeignKey("UserModelUserId");
                });

            modelBuilder.Entity("XFitness.Models.Entities.UserPsychicalParametersModel", b =>
                {
                    b.HasOne("XFitness.Models.Entities.UserModel", null)
                        .WithMany("PsychicalParameters")
                        .HasForeignKey("UserModelUserId");
                });

            modelBuilder.Entity("XFitness.Models.Entities.UserExerciseProgramModel", b =>
                {
                    b.Navigation("Exercises");

                    b.Navigation("ProgramExerciseProgresses");
                });

            modelBuilder.Entity("XFitness.Models.Entities.UserModel", b =>
                {
                    b.Navigation("ExercisePrograms");

                    b.Navigation("PsychicalParameters");
                });
#pragma warning restore 612, 618
        }
    }
}
