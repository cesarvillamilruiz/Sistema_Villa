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
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Ultima Venta")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Esta Disponible ?")]
        public bool IsAvailabe { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }
        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImageUrl))
                {
                    return null;
                }

                return $"http://localhost:55654{this.ImageUrl.Substring(1)}";
            }
        }


        public User User { get; set; }

    }

}
