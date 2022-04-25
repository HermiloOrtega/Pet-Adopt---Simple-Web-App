using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PetAdopt.Models
{
    enum ApplicationStatus
    {
        active = 1,
        approved = 2,
        rejected = 3, 
        deleted = 4
    }
    public class AdoptApplication
    {
        #region Constructor

        #endregion

        #region Attribute
        #endregion

        #region Properties
            [Required(ErrorMessage = "Id required")]
            [Display(Name = "Id")]
            public string Id { get; set; }

            [Required(ErrorMessage = "Status required")]
            [Display(Name = "Status")]
            public string Status { get; set; }

            [Required(ErrorMessage = "Date Registered required")]
            [Display(Name = "Date Registered")]
            public DateTime DateRegistered { get; set; }

            [Required(ErrorMessage = "Date Approved required")]
            [Display(Name = "Date Approved")]
            public DateTime DateApproved { get; set; }

            [Required(ErrorMessage = "Date Rejected required")]
            [Display(Name = "Date Rejected")]
            public DateTime DateRejected { get; set; }

            [Required(ErrorMessage = "Date Deleted required")]
            [Display(Name = "Date Deleted")]
            public string DateDeleted { get; set; }

            [Required(ErrorMessage = "People At Home required")]
            [Display(Name = "People At Home")]
            public string PeopleAtHome { get; set; }

            [Display(Name = "Children At Home")]
            public string ChildrenAtHome { get; set; }

            [Display(Name = "Children Ages")]
            public string ChildrenAges { get; set; }

            [Required(ErrorMessage = "Home Antiguety required")]
            [Display(Name = "Home Antiguety")]
            public string HomeAntiguety { get; set; }

            [Display(Name = "Landlord Consent For Pets")]
            public string LandlordConsentForPets { get; set; }

            [Display(Name = "Landlord Information")]
            public string LandlordInformation { get; set; }

            [Display(Name = "Strata")]
            public string Strata { get; set; }

            [Required(ErrorMessage = "Moving Next Six Months required")]
            [Display(Name = "Moving Next Six Months")]
            public string MovingNextSixMonths { get; set; }

            [Required(ErrorMessage = "Pet Is A Gift required")]
            [Display(Name = "Pet Is A Gift")]
            public string PetIsAGift { get; set; }

            [Required(ErrorMessage = "Time Thought To Get A Pet required")]
            [Display(Name = "Time Thought To Get A Pet")]
            public string TimeThoughtToGetAPet { get; set; }

            [Required(ErrorMessage = "Why A Pet required")]
            [Display(Name = "Why A Pet")]
            public string WhyAPet { get; set; }

            [Required(ErrorMessage = "FoodEstimateExpense required")]
            [Display(Name = "FoodEstimateExpense")]
            public string FoodEstimateExpense { get; set; }

            [Required(ErrorMessage = "Medical Estimate Expense required")]
            [Display(Name = "Medical Estimate Expense")]
            public string MedicalEstimateExpense { get; set; }

            [Required(ErrorMessage = "Misc Estimate Expense required")]
            [Display(Name = "Misc Estimate Expense")]
            public string MiscEstimateExpense { get; set; }

            [Required(ErrorMessage = "Emergency Estimate Expense required")]
            [Display(Name = "Emergency Estimate Expense")]
            public string EmergencyEstimateExpense { get; set; }

            [Required(ErrorMessage = "Initials Provide Essentials required")]
            [Display(Name = "Initials Provide Essentials")]
            public string InitialsProvideEssentials { get; set; }

            [Required(ErrorMessage = "Initials Nurturing Environment required")]
            [Display(Name = "Initials Nurturing Environment")]
            public string InitialsNurturingEnvironment { get; set; }

            [Required(ErrorMessage = "Initials Animal Control By Law required")]
            [Display(Name = "Initials Animal Control By Law")]
            public string InitialsAnimalControlByLaw { get; set; }

            [Required(ErrorMessage = "Initials Contact Animal Shelter required")]
            [Display(Name = "InitialsContactAnimalShelter")]
            public string InitialsContactAnimalShelter { get; set; }

            [Required(ErrorMessage = "Initials 14 Days Return required")]
            [Display(Name = "Initials 14 Days Return")]
            public string Initials14DaysReturn { get; set; }

            [Required(ErrorMessage = "Signature Application required")]
            [Display(Name = "Signature Application")]
            public string SignatureApplication { get; set; }

            [Required(ErrorMessage = "Id Pet required")]
            [Display(Name = "Id Pet")]
            public Pet Pet { get; set; }
            
            [Required(ErrorMessage = "User Email required")]
            [Display(Name = "User Email")]
            public string userEmail { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
