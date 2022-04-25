using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetAdopt.Models
{
    /// <summary>
    /// Represents an enum of the Pet Status
    /// </summary>
    public enum Status
    {
        active = 1,
        inactive = 2,
    }
    /// <summary>
    /// Represents an enum of the Pet Status
    /// </summary>
    public enum PetAdopted
    {
        No = 1,
        inactive = 2,
    }
    /// <summary>
    /// Represents the Pet Size 
    /// </summary>
    public enum Size
    {
        small = 1,
        medium = 2,
        big = 3,
        extraBig = 4,
    }
    /// <summary>
    /// Represents the Pet Gender
    /// </summary>
    public enum Gender
    {
        male = 1,
        female = 2,
    }
    /// <summary>
    /// Represents the Pet Type
    /// </summary>
    public enum PetType
    {
        dog = 1,
        cat = 2,
    }
    /// <summary>
    /// 
    /// </summary>
    public class Pet
    {
        
        #region Constructor
        #endregion

        #region Attribute
        #endregion

        #region Properties
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Status")]
        public Status Status { get; set; }

        [Display(Name = "Pet Type")]
        public PetType PetType { get; set; }

        [Required(ErrorMessage = "Adopted required")]
        [Display(Name = "Adopted")]
        public string Adopted { get; set; }

        [Required(ErrorMessage = "Date Registered required")]
        [Display(Name = "Date Registered")]
        public string DateRegistered { get; set; }

        [Display(Name = "Date Deleted")]
        public string DateDeleted { get; set; }

        [Display(Name = "Date Adopted")]
        public string DateAdopted { get; set; }

        [Required(ErrorMessage = "Name required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location required")]
        [Display(Name = "Location")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Breed required")]
        [Display(Name = "Breed")]
        public string Breed { get; set; }

        [Required(ErrorMessage = "Color required")]
        [Display(Name = "Color")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Age required")]
        [Display(Name = "Age")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Size required")]
        [Display(Name = "Size")]
        public string Size { get; set; }

        [Required(ErrorMessage = "Gender required")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Description required")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "House Trained required")]
        [Display(Name = "House Trained")]
        public string HouseTrained { get; set; }

        [Required(ErrorMessage = "Adoption Fee required")]
        [Display(Name = "Adoption Fee")]
        public string AdoptionFee { get; set; }

        [Required(ErrorMessage = "PhotoUrl required")]
        [Display(Name = "PhotoUrl")]
        public string PhotoUrl { get; set; }

        #endregion

        #region Methods
        #endregion
    }
}
