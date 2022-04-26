using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetAdopt.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Pet
    {

        #region Constructor
        public Pet()
        {

        }
        #endregion

        #region AttributePetHouseTrained
        public enum PetHouseTrained
        {
            Yes,
            No
        }
        public enum PetGender
        {
            Male,
            Female
        }
        public enum PetSize
        {
            Small,
            Medium,
            Large,
            ExtraLarge
        }
        public enum PetType
        {
            Cat,
            Dog
        }
        public enum PetAdopted
        {
            Yes = 0,
            No = 1
        }
        #endregion

        #region Properties

        #region Basic Information
                [Key]
                [Display(Name = "Id")]
            public int Id { get; set; }
        
                [Required(ErrorMessage = "Pet Type required")]
                [Display(Name = "Pet Type")]
            public PetType Type { get; set; }
            
                [Required(ErrorMessage = "Adopted required")]
                [Display(Name = "Adopted")]
            public PetAdopted Adopted { get; set; } = PetAdopted.No;
        
                [Required(ErrorMessage = "Name required")]
                [Display(Name = "Name")]
                [MaxLength(150)]
            public string Name { get; set; }
        
                [Required(ErrorMessage = "Location required")]
                [Display(Name = "Location")]
                [MaxLength(50)]
            public string Location { get; set; }

                [Required(ErrorMessage = "Photo URL required")]
                [Display(Name = "Photo URL")]
            public string PhotoURL { get; set; } = "http://";
        #endregion

        #region Details Information
                [Display(Name = "Breed")]
                [MaxLength(50)]
            public string? Breed { get; set; }
        
        
                [Display(Name = "Color")]
                [MaxLength(50)]
            public string? Color { get; set; }
        
        
                [Display(Name = "Age")]
                [Range(minimum: 0, maximum: int.MaxValue)]
            public int? Age { get; set; } = 0;
        
        
                [Required(ErrorMessage = "Size required")]
                [Display(Name = "Size")]
            public PetSize Size { get; set; }
        
        
                [Required(ErrorMessage = "Gender required")]
                [Display(Name = "Gender")]
            public PetGender Gender { get; set; }
        
        
                [Display(Name = "Description")]
                [DataType(DataType.MultilineText)]
                [MaxLength(200)]
            public string? Description { get; set; }
        
        
                [Required(ErrorMessage = "House Trained required")]
                [Display(Name = "House-trained")]
            public PetHouseTrained HouseTrained { get; set; } = PetHouseTrained.No;
        
        
                [Display(Name = "Adoption Fee")]
                [Range(minimum: 0, maximum: double.MaxValue)]
                [DataType(DataType.Currency)]
            public double? AdoptionFee { get; set; } = 0;
        #endregion

        #endregion

        #region Methods
        #endregion
    }
}