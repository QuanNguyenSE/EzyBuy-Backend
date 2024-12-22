using AutoMapper;
using EzyBuy.Application.Brands.Commands.CreateBrand;
using EzyBuy.Domain.Models;

namespace EzyBuy.Application.Brands.Dtos;

public class BrandProfile : Profile
{
    public BrandProfile()
    {
        CreateMap<Brand, BrandDto>();
        CreateMap<CreateBrandCommand, Brand>();
    }
}
