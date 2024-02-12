using Application.Features.ProfileLanguages.Commands.Create;
using Application.Features.ProfileLanguages.Commands.Delete;
using Application.Features.ProfileLanguages.Commands.Update;
using Application.Features.ProfileLanguages.Queries.GetById;
using Application.Features.ProfileLanguages.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Domain.Entities;
using Core.Persistence.Paging;
using Application.Features.ProfileLanguages.Queries.GetAllLanguageByUserId;

namespace Application.Features.ProfileLanguages.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<ProfileLanguage, CreateProfileLanguageCommand>().ReverseMap();
        CreateMap<ProfileLanguage, CreatedProfileLanguageResponse>().ReverseMap();
        CreateMap<ProfileLanguage, UpdateProfileLanguageCommand>().ReverseMap();
        CreateMap<ProfileLanguage, UpdatedProfileLanguageResponse>().ReverseMap();
        CreateMap<ProfileLanguage, DeleteProfileLanguageCommand>().ReverseMap();
        CreateMap<ProfileLanguage, DeletedProfileLanguageResponse>().ReverseMap();
        CreateMap<ProfileLanguage, GetByIdProfileLanguageResponse>().ReverseMap();
        CreateMap<ProfileLanguage, GetListProfileLanguageListItemDto>().ReverseMap();
        CreateMap<ProfileLanguage, GetAllLanguageByUserIdResponse>()
            .ForMember(x=>x.Name, opt=>opt.MapFrom(x=>x.Language.Name))
            .ForMember(x=>x.Level, opt=>opt.MapFrom(x=>x.Language.LanguageLevel.Name))
            .ReverseMap();
        CreateMap<IPaginate<ProfileLanguage>, GetListResponse<GetListProfileLanguageListItemDto>>().ReverseMap();
        CreateMap<IPaginate<ProfileLanguage>, GetListResponse<GetAllLanguageByUserIdResponse>>().ReverseMap();
    }
}