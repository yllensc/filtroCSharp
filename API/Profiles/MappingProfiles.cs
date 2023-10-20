using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles;

public class MappingProfiles : Profile
{

    public MappingProfiles()
    {
        CreateMap<User, UserWithRolDto>().ReverseMap();
        //.ForMember(dest => dest.Movement, opt => opt.MapFrom(src => src.TypeMovement.Name))
        CreateMap<Veterinarian, VeterinarianDto>().ReverseMap();
    }

}
