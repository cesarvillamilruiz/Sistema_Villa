namespace Sis.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product:IEntity
    {
        public int Id { get; set; }

        [StringLength(50,ErrorMessage ="El campo {0} debe tener entre 1 y {1} caracteres")]
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        [Display(Name = "Ultima Compra")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Ultima Venta")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Esta Disponible ?")]
        public bool IsAvailabe { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        public User User { get; set; }
    }

}
