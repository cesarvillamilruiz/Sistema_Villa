

namespace Sis.Web.Models
{
    using Microsoft.AspNetCore.Http;    
    using System.ComponentModel.DataAnnotations;
    using Data.Entities;
    public class ProductViewModel:Product
    {
        [Display(Name ="Imagen")]
        public IFormFile ImageFile { get; set; }
    }
}
