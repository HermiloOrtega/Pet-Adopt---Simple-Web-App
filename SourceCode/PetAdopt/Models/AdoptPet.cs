using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PetAdopt.Models
{
    public class AdoptPet
    {
        #region Constructor
        public AdoptPet()
        {

        }
        #endregion

        #region Attribute
        public enum ApplicationStatus{
            Active,
            Accepted,
            Rejected,
            Deleted
        }
        #endregion

        #region Properties

        #region Basic Information
                [Key]
                [Required(ErrorMessage = "Id required")]
            public int Id { get; set; }


                [Required(ErrorMessage = "Status required")]
            public ApplicationStatus Status { get; set; }


                [Required(ErrorMessage = "Date Registered required")]
                [Display(Name = "Date Registered")]
            public DateTime DateRegistered { get; set; } = DateTime.Now;


                [Display(Name = "Date Approved")]
            public DateTime? DateApproved { get; set; }
        #endregion

        #region Home Information
                [Required(ErrorMessage = "People At Home required")]
                [Display(Name = "How Many people live in your household? ")]
                [Range(minimum: 0, maximum: 20)]
            public int PeopleAtHome { get; set; } = 0;


                [Required(ErrorMessage = "Childrens at home Required")]
                [Display(Name = "Do you have children in your home? (Yes / No)")]
            public bool ChildrenAtHome { get; set; }


                [Display(Name = "Specify Ages")]
                [DataType(DataType.Text)]
            public string? ChildrenAges { get; set; }


                [Required(ErrorMessage = "Home Antiguety required")]
                [Display(Name = "How long have you been at this address? (Years)")]
                [Range(minimum: 0, maximum: 999)]
            public int HomeAntiguety { get; set; } = 0;


                [Display(Name = "Do you have the written consent of your landlord to have an animal in your home? (Yes / No)")]
            public bool LandlordConsentForPets { get; set; }


                [Display(Name = "Name and phone number of the landlord")]
                [DataType(DataType.Text)]
            public string? LandlordInformation { get; set; }


                [Required(ErrorMessage = "Strata required")]
                [Display(Name = "Do you live in an Strata? (Yes / No)")]
            public bool Strata { get; set; }


                [Required(ErrorMessage = "Moving Next Six Months required")]
                [Display(Name = "Are you planning on moving in the next 6 months? (Yes / No)")]
            public bool MovingNextSixMonths { get; set; }
        #endregion

        #region Adoption Information
                [Required(ErrorMessage = "Pet Is A Gift required")]
                [Display(Name = "Is this pet a gift? (Yes / No)")]
            public bool PetIsAGift { get; set; }


                [Required(ErrorMessage = "Time Thought To Get A Pet required")]
                [Display(Name = "How much time and thought have you put into welcoming your new dog?")]
                [Range(minimum: 0, maximum: int.MaxValue)]
            public int TimeThoughtToGetAPet { get; set; } = 0;


                [Required(ErrorMessage = "Why A Pet required")]
                [Display(Name = "Why did you decided to add a dog to your family? ")]
                [DataType(DataType.MultilineText)]
            public string WhyAPet { get; set; }


                [Required(ErrorMessage = "FoodEstimateExpense required")]
                [Display(Name = "How much do you estimate your expenses will be for your pet first year? (Food)")]
                [Range(minimum: 0, maximum: double.MaxValue)]
                [DataType(DataType.Currency)]
            public double FoodEstimateExpense { get; set; } = 0.0;


                [Required(ErrorMessage = "Medical Estimate Expense required")]
                [Display(Name = "How much do you estimate your expenses will be for your pet first year? (Medical)")]
                [Range(minimum: 0, maximum: double.MaxValue)]
                [DataType(DataType.Currency)]
            public double MedicalEstimateExpense { get; set; } = 0.0;


                [Required(ErrorMessage = "Misc Estimate Expense required")]
                [Display(Name = "How much do you estimate your expenses will be for your pet first year? (Misc)")]
                [Range(minimum: 0, maximum: double.MaxValue)]
                [DataType(DataType.Currency)]
            public double MiscEstimateExpense { get; set; } = 0.0;


                [Required(ErrorMessage = "Emergency Estimate Expense required")]
                [Display(Name = "How much are you able or willing to spend in the case of an emergency?")]
                [Range(minimum: 0, maximum: double.MaxValue)]
                [DataType(DataType.Currency)]
            public double EmergencyEstimateExpense { get; set; } = 0.0;
        #endregion

        #region Consents Information
                [Required(ErrorMessage = "Initials Provide Essentials required")]
                [Display(Name = "To provide the adopted animal with adequate food, water, shelter, exercise  veterinary care as required for so long as I own the animal.Initial \n To provide a nurturing and loving environment.Initial")]
            public string InitialsProvideEssentials { get; set; }


                [Required(ErrorMessage = "Initials Nurturing Environment required")]
                [Display(Name = "To provide a nurturing and loving environment. Initial")]
            public string InitialsNurturingEnvironment { get; set; }


                [Required(ErrorMessage = "Initials Animal Control By Law required")]
                [Display(Name = "To comply with my municipality’s Animal Control Bylaw (as amended or superseded from time to time), as it relates to my animal, including, without limitation, if my animal is a dog, obtaining an annual license, abiding by the “pooper scooper” laws, having my dog on leash and under control at all times unless permitted to be off leash in designated City areas and, if my animal is a cat, ensuring that it has proper identification(i.e.a collar, tattoo or microchip). Initial")]
            public string InitialsAnimalControlByLaw { get; set; }


                [Required(ErrorMessage = "Initials Contact Animal Shelter required")]
                [Display(Name = "In the event I can no longer keep this pet, I will contact the Animal Shelter. Initial")]
            public string InitialsContactAnimalShelter { get; set; }


                [Required(ErrorMessage = "Initials 14 Days Return required")]
                [Display(Name = "I understand that the City cannot guarantee the behaviour or health of any animal that I choose to adopt.I understand that once I have adopted the animal I have 14 days in which to satisfy myself as to the animal’s health and temperament and, should I wish, to return the animal to the Shelter for a full refund of my adoption fees(dog license fees are non - refundable).The animal is my sole responsibility both during the 14 day guarantee period and after that period expires.I understand that in the event that, after the 14 day period has expired, I can no longer provide a home for the animal, I do have the option to bring the animal back to the Coquitlam Animal Shelter, although my adoption fee will not be refunded. Initial")]
            public string Initials14DaysReturn { get; set; }


                [Required(ErrorMessage = "Signature Application required")]
                [Display(Name = "Signature")]
            public string SignatureApplication { get; set; }
        #endregion 

        #region Links Information
                [Required(ErrorMessage = "Id Pet required")]
                [Display(Name = "Id Pet")]
            public virtual Pet Pet { get; set; }


                [Required(ErrorMessage = "User Email required")]
                [Display(Name = "User Email")]
            public virtual string? userEmail { get; set; }
        #endregion

        #endregion

        #region Methods

        #endregion
    }
}
