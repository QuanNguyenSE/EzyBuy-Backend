using EzyBuy.Application.Brands.Dtos;
using MediatR;

namespace EzyBuy.Application.Brands.Queries.GetAllBrands;

public class GetAllBrandsQuery : IRequest<IEnumerable<BrandDto>>
{
}
