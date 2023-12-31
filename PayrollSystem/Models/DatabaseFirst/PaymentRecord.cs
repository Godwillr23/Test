//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PayrolSystem.Models.DatabaseFirst
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class PaymentRecord
    {
        public int PaymentID { get; set; }

        [Display(Name = "Payment Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select Payment Type")]
        public int CompanyID { get; set; }

        [Display(Name = "Payment Status")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select Payment Status")]
        public string PaymentType { get; set; }
        public string PaymentStatus { get; set; }

        public string PaymentDate { get; set; }
        public string PaymentTime { get; set; }
    }
}
