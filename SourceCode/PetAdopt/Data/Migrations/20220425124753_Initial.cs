using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetAdopt.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    PetType = table.Column<string>(nullable: false),
                    Adopted = table.Column<string>(nullable: false),
                    DateRegistered = table.Column<string>(nullable: false),
                    DateDeleted = table.Column<string>(nullable: true),
                    DateAdopted = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Breed = table.Column<string>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    Age = table.Column<string>(nullable: false),
                    Size = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    HouseTrained = table.Column<string>(nullable: false),
                    AdoptionFee = table.Column<string>(nullable: false),
                    PhotoUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdoptApplication",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    DateRegistered = table.Column<DateTime>(nullable: false),
                    DateApproved = table.Column<DateTime>(nullable: false),
                    DateRejected = table.Column<DateTime>(nullable: false),
                    DateDeleted = table.Column<string>(nullable: false),
                    PeopleAtHome = table.Column<string>(nullable: false),
                    ChildrenAtHome = table.Column<string>(nullable: true),
                    ChildrenAges = table.Column<string>(nullable: true),
                    HomeAntiguety = table.Column<string>(nullable: false),
                    LandlordConsentForPets = table.Column<string>(nullable: true),
                    LandlordInformation = table.Column<string>(nullable: true),
                    Strata = table.Column<string>(nullable: true),
                    MovingNextSixMonths = table.Column<string>(nullable: false),
                    PetIsAGift = table.Column<string>(nullable: false),
                    TimeThoughtToGetAPet = table.Column<string>(nullable: false),
                    WhyAPet = table.Column<string>(nullable: false),
                    FoodEstimateExpense = table.Column<string>(nullable: false),
                    MedicalEstimateExpense = table.Column<string>(nullable: false),
                    MiscEstimateExpense = table.Column<string>(nullable: false),
                    EmergencyEstimateExpense = table.Column<string>(nullable: false),
                    InitialsProvideEssentials = table.Column<string>(nullable: false),
                    InitialsNurturingEnvironment = table.Column<string>(nullable: false),
                    InitialsAnimalControlByLaw = table.Column<string>(nullable: false),
                    InitialsContactAnimalShelter = table.Column<string>(nullable: false),
                    Initials14DaysReturn = table.Column<string>(nullable: false),
                    SignatureApplication = table.Column<string>(nullable: false),
                    PetId = table.Column<string>(nullable: false),
                    userEmail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdoptApplication_Pet_PetId",
                        column: x => x.PetId,
                        principalTable: "Pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdoptApplication_PetId",
                table: "AdoptApplication",
                column: "PetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdoptApplication");

            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
