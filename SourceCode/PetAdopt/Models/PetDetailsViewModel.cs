using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetAdopt.Models
{
    public class PetDetailsViewModel
    {
        public Pet Pet { get; set; }
        public List<AdoptionForm> AdoptPets { set; get; }

        public int PetID { get; set; }
        [Required(ErrorMessage = "Status required")]
        public AdoptionForm.ApplicationStatus Status { get; set; }
        [Required(ErrorMessage = "Date Registered required")]
        [Display(Name = "Date Registered")]
        public DateTime DateRegistered { get; set; } = DateTime.Now;
    }
}
