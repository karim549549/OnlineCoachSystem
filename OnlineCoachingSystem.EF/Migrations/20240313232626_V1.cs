using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCoachingSystem.EF.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: true),
                    MoreHealthDetails = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PersonalDetails_BirthdayDate = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    PersonalDetails_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalDetails_From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalDetails_Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalDetails_LiveIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalDetails_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalDetails_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalDetails_ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PersonalDetails_Username = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coachs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Experiences = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    BeforePhoto = table.Column<byte[]>(type: "varbinary(1000)", maxLength: 1000, nullable: true),
                    person_BirthdayDate = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    person_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    person_From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    person_Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    person_LiveIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    person_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    person_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    person_ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    person_Username = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coachs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NeutrationPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CoachId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NeutrationPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientCoach",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CoachId = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeutrationPlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCoach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientCoach_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientCoach_Coachs_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coachs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WorkingMuscles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CoachId = table.Column<int>(type: "int", nullable: false),
                    IntensityLevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_Coachs_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coachs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseNeutrationPlan",
                columns: table => new
                {
                    ExercisesId = table.Column<int>(type: "int", nullable: false),
                    NeutrationPlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseNeutrationPlan", x => new { x.ExercisesId, x.NeutrationPlanId });
                    table.ForeignKey(
                        name: "FK_ExerciseNeutrationPlan_Exercises_ExercisesId",
                        column: x => x.ExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseNeutrationPlan_NeutrationPlans_NeutrationPlanId",
                        column: x => x.NeutrationPlanId,
                        principalTable: "NeutrationPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientCoach_ClientId",
                table: "ClientCoach",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCoach_CoachId",
                table: "ClientCoach",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseNeutrationPlan_NeutrationPlanId",
                table: "ExerciseNeutrationPlan",
                column: "NeutrationPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_CoachId",
                table: "Exercises",
                column: "CoachId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientCoach");

            migrationBuilder.DropTable(
                name: "ExerciseNeutrationPlan");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "NeutrationPlans");

            migrationBuilder.DropTable(
                name: "Coachs");
        }
    }
}
