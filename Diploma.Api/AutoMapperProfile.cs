﻿using AutoMapper;
using Diploma.Domain.Entities;
using Diploma.DTO;

namespace Diploma.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Item, ItemDTO>();
            CreateMap<Category, CategoryDTO>();
            CreateMap<ItemType, ItemTypeDTO>();
            CreateMap<ItemVariant, ItemVariantDTO>();
        }
    }
}
