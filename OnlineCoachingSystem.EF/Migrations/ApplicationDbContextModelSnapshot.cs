﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineCoachingSystem.EF;

#nullable disable

namespace OnlineCoachingSystem.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExerciseNeutrationPlan", b =>
                {
                    b.Property<int>("ExercisesId")
                        .HasColumnType("int");

                    b.Property<int>("NeutrationPlanId")
                        .HasColumnType("int");

                    b.HasKey("ExercisesId", "NeutrationPlanId");

                    b.HasIndex("NeutrationPlanId");

                    b.ToTable("ExerciseNeutrationPlan");
                });

            modelBuilder.Entity("OnlineCoachingSystem.Repository.Models.Plan.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IntensityLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("WorkingMuscles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoachId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("OnlineCoachingSystem.Repository.Models.Plan.NeutrationPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("NeutrationPlans");
                });

            modelBuilder.Entity("OnlineCoachingSystem.Repository.Models.User.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<string>("MoreHealthDetails")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.ComplexProperty<Dictionary<string, object>>("PersonalDetails", "OnlineCoachingSystem.Repository.Models.User.Client.PersonalDetails#Person", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<DateTime?>("BirthdayDate")
                                .IsConcurrencyToken()
                                .ValueGeneratedOnAddOrUpdate()
                                .HasColumnType("datetime2");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("From")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Gender")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("LiveIn")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Password")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PhoneNumber")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<byte[]>("ProfilePicture")
                                .HasColumnType("varbinary(max)");

                            b1.Property<string>("Username")
                                .IsRequired()
                                .HasMaxLength(25)
                                .HasColumnType("nvarchar(25)");
                        });

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("OnlineCoachingSystem.Repository.Models.User.ClientCoach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<int>("NeutrationPlanId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("CoachId");

                    b.ToTable("ClientCoach");
                });

            modelBuilder.Entity("OnlineCoachingSystem.Repository.Models.User.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("BeforePhoto")
                        .HasMaxLength(1000)
                        .HasColumnType("varbinary(1000)");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Degree")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Experiences")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.ComplexProperty<Dictionary<string, object>>("person", "OnlineCoachingSystem.Repository.Models.User.Coach.person#Person", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<DateTime?>("BirthdayDate")
                                .IsConcurrencyToken()
                                .ValueGeneratedOnAddOrUpdate()
                                .HasColumnType("datetime2");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("From")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Gender")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("LiveIn")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Password")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PhoneNumber")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<byte[]>("ProfilePicture")
                                .HasColumnType("varbinary(max)");

                            b1.Property<string>("Username")
                                .IsRequired()
                                .HasMaxLength(25)
                                .HasColumnType("nvarchar(25)");
                        });

                    b.HasKey("Id");

                    b.ToTable("Coachs");
                });

            modelBuilder.Entity("ExerciseNeutrationPlan", b =>
                {
                    b.HasOne("OnlineCoachingSystem.Repository.Models.Plan.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCoachingSystem.Repository.Models.Plan.NeutrationPlan", null)
                        .WithMany()
                        .HasForeignKey("NeutrationPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineCoachingSystem.Repository.Models.Plan.Exercise", b =>
                {
                    b.HasOne("OnlineCoachingSystem.Repository.Models.User.Coach", "Coach")
                        .WithMany("Exercises")
                        .HasForeignKey("CoachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("OnlineCoachingSystem.Repository.Models.User.ClientCoach", b =>
                {
                    b.HasOne("OnlineCoachingSystem.Repository.Models.User.Client", "Client")
                        .WithMany("clientCoach")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCoachingSystem.Repository.Models.User.Coach", "Coach")
                        .WithMany("clientCoach")
                        .HasForeignKey("CoachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("OnlineCoachingSystem.Repository.Models.User.Client", b =>
                {
                    b.Navigation("clientCoach");
                });

            modelBuilder.Entity("OnlineCoachingSystem.Repository.Models.User.Coach", b =>
                {
                    b.Navigation("Exercises");

                    b.Navigation("clientCoach");
                });
#pragma warning restore 612, 618
        }
    }
}
