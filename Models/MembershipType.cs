using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalMovieApp.Models
{
    public class MembershipType
    {
        public int Id { get; set; } 
        public short SignupFee { get; set; } 
        public byte DurationInMonths { get; set; } 
        public byte DiscountRate { get; set; }
        [Required]
        public string Name { get; set; }    
    }
}