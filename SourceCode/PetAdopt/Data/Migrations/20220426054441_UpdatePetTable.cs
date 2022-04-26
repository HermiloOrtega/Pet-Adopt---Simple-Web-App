using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetAdopt.Data.Migrations
{
    public partial class UpdatePetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateRegistered",
                table: "Pet");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pet",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Pet",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "AdoptionFee",
                table: "Pet",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Pet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "Pet",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Pet",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pet",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Pet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HouseTrained",
                table: "Pet",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PhotoURL",
                table: "Pet",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Pet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ChildrenAges",
                table: "AdoptApplication",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ChildrenAtHome",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateApproved",
                table: "AdoptApplication",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "EmergencyEstimateExpense",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FoodEstimateExpense",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "HomeAntiguety",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Initials14DaysReturn",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InitialsAnimalControlByLaw",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InitialsContactAnimalShelter",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InitialsNurturingEnvironment",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InitialsProvideEssentials",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LandlordConsentForPets",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LandlordInformation",
                table: "AdoptApplication",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MedicalEstimateExpense",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MiscEstimateExpense",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "MovingNextSixMonths",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PeopleAtHome",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "PetIsAGift",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SignatureApplication",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Strata",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TimeThoughtToGetAPet",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WhyAPet",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userEmail",
                table: "AdoptApplication",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdoptionFee",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "HouseTrained",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "PhotoURL",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "ChildrenAges",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "ChildrenAtHome",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "DateApproved",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "EmergencyEstimateExpense",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "FoodEstimateExpense",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "HomeAntiguety",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "Initials14DaysReturn",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "InitialsAnimalControlByLaw",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "InitialsContactAnimalShelter",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "InitialsNurturingEnvironment",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "InitialsProvideEssentials",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "LandlordConsentForPets",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "LandlordInformation",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "MedicalEstimateExpense",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "MiscEstimateExpense",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "MovingNextSixMonths",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "PeopleAtHome",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "PetIsAGift",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "SignatureApplication",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "Strata",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "TimeThoughtToGetAPet",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "WhyAPet",
                table: "AdoptApplication");

            migrationBuilder.DropColumn(
                name: "userEmail",
                table: "AdoptApplication");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRegistered",
                table: "Pet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
