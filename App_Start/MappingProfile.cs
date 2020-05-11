using AutoMapper;
using RentalMovieApp.DTO;
using RentalMovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalMovieApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}