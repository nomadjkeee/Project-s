using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using VidlyAuth.Dto;
using VidlyAuth.Models;

namespace VidlyAuth.App_Start
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            Mapper.CreateMap<Movies, MoviesDto>();

            Mapper.CreateMap<MoviesDto, Movies>()
                .ForMember(t => t.Id, opt => opt.Ignore());

            Mapper.CreateMap<Genre, GenreDto>();

            Mapper.CreateMap<GenreDto, Genre>()
                .ForMember(t => t.Id, opt => opt.Ignore());

            Mapper.CreateMap<Customer, CustomerDto>();

            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(t => t.Id, opt => opt.Ignore());

            Mapper.CreateMap<MemberShip, MemberShipDto>();

            Mapper.CreateMap<MemberShipDto, MemberShip>()
                .ForMember(t => t.Id, opt => opt.Ignore());

        }
    }
}