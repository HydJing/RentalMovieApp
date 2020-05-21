using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalMovieApp.DTO
{
    public class NewRentalDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public List<int> MovieIds { get; set; }
    }
}