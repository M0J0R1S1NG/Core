using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models.ManageViewModels;
using Core.Models.AccountViewModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Core.Models
{
    public class Order
    {
         
        public int ID { get; set; }
        public Guid  GUID  { get; set; }

        public int CustomerId { get; set; }
        public Guid AppUser { get; set; }
        [Display(Name = "Order Date")]
        [DisplayFormat(HtmlEncode = false, ApplyFormatInEditMode = true,DataFormatString="{0:dddd, MMMM dd, yyyy hh:mm}")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "ETA / Delivery Date")]
        [DisplayFormat(HtmlEncode = false, ApplyFormatInEditMode = true,DataFormatString="{0:dddd, MMMM dd, yyyy hh:mm}")]
        public DateTime DeliveryDate { get; set; }
        [Display(Name = "Delivery Address")]
        public string GeocodedAddress { get; set; }   
        [Display(Name = "Delivery Phone Number")]
        public string PhoneNumber { get; set; }
        public decimal Total { get; set; }

        [Display(Name = "Being used to hold deliveryFlatFee")]
        public decimal Weight { get; set; }
        [Display(Name = "Payment Type")]
        public int PaymentType { get; set; }
        [Display(Name = "Order Details")]
        public string Details { get; set; }
        [Display(Name = "Special Delivery Instructions")]
        public string SpecialInstructions { get; set; }
        [Display(Name = "Order Status")]
        public int Status { get; set; }
        public int DriverId { get; set; }


    }
}


