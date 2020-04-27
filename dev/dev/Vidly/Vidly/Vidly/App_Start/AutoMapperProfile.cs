using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();

            Mapper.CreateMap<MemberShip, MemberShipDto>();

            Mapper.CreateMap<MemberShipDto, MemberShip>()
                .ForMember(t => t.Id, opt => opt.Ignore());

            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(t => t.Id, opt => opt.Ignore());

            Mapper.CreateMap<Movies, MoviesDto>();

            Mapper.CreateMap<MoviesDto, Movies>()
                .ForMember(t => t.Id, opt => opt.Ignore());

            Mapper.CreateMap<GenreDto, Genre>()
                .ForMember(t => t.Id, opt => opt.Ignore());

            Mapper.CreateMap<Genre, GenreDto>();


        }
    }
}