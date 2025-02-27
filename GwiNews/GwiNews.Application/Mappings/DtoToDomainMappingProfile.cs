﻿using AutoMapper;
using GwiNews.Application.DTOs.FormationDTO;
using GwiNews.Application.DTOs.News;
using GwiNews.Application.DTOs.NewsCategory;
using GwiNews.Application.DTOs.NewsSubcategory;
using GwiNews.Application.DTOs.ProfessionalInformation;
using GwiNews.Application.DTOs.ProfessionalSkill;
using GwiNews.Application.DTOs.ReaderUser;
using GwiNews.Application.DTOs.UserWithNews;
using GwiNews.Domain.Entities;

namespace GwiNews.Application.Mappings
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile() 
        {
            CreateMap<CreateUserWithNewsDTO, UserWithNews>();
            CreateMap<UpdateUserWithNewsDTO, UserWithNews>();
            CreateMap<CreateNewsDTO, News>();
            CreateMap<UpdateNewsDTO, News>();
            CreateMap<CreateNewsCategoryDTO, NewsCategory>();
            CreateMap<UpdateNewsCategoryDTO, NewsCategory>();
            CreateMap<CreateNewsSubcategoryDTO, NewsSubcategory>();
            CreateMap<UpdateNewsSubcategoryDTO, NewsSubcategory>();
            CreateMap<CreateReaderUserDTO, ReaderUser>();
            CreateMap<UpdateReaderUserDTO, ReaderUser>();
            CreateMap<CreateProfessionalInformationDTO, ProfessionalInformation>();
            CreateMap<UpdateProfessionalInformationDTO, ProfessionalInformation>();
            CreateMap<CreateProfessionalSkillDTO, ProfessionalSkill>();
            CreateMap<UpdateProfessionalSkillDTO, ProfessionalSkill>();
            CreateMap<CreateFormationDTO, Formation>();
            CreateMap<UpdateFormationDTO, Formation>();
        }
    }
}
