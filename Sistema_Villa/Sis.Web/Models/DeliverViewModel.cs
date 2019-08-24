
namespace Sis.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DeliverViewModel
    {
        public int Id { get; set; }




        [Display(Name = "Fecha de entrega")]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }
    }

}
