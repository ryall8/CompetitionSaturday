using System.Linq;
using AutoMapper;
using CompetitionSaturday.API.Dtos;
using CompetitionSaturday.API.Models;

namespace CompetitionSaturday.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.Age, opt => 
                    opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserForDetailsDto>()
                .ForMember(dest => dest.Age, opt => 
                    opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Competition, CompetitionForDetailsDto>()
                .ForMember(dest => dest.Competitors, opt =>
                    opt.MapFrom(src => src.Competitors));
            CreateMap<Competition, CompetitionForListDto>();
            CreateMap<CompetitionUser, CompetitorDto>()
                .ForMember(dest => dest.CompetitionId, opt =>
                    opt.MapFrom(src => src.CompetitionId))
                .ForMember(dest => dest.UserId, opt =>
                    opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.KnownAs, opt =>
                    opt.MapFrom(src => src.User.KnownAs))
                .ForMember(dest => dest.PhotoUrl, opt =>
                    opt.MapFrom(src => src.User.Photo.Url));
        }
    }
}