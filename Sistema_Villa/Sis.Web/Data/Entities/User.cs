


namespace Sis.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User:IdentityUser
    {
        [Display(Name = "Primer Nombre")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string FirstName { get; set; }
        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]


        [Display(Name = "Segundo Nombre")]
        public string LastName { get; set; }


        [Display(Name = "Phone Number")]
        public override string PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }


        [Display(Name ="Nombre Completo")]
        public string FullName { get { return $"{this.FirstName } {this.LastName}"; } }

        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string Address { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        [Display(Name = "Email Confirmed")]
        public override bool EmailConfirmed { get => base.EmailConfirmed; set => base.EmailConfirmed = value; }

        [NotMapped]
        [Display(Name = "Is Admin?")]
        public bool IsAdmin { get; set; }



    }
}
