using EzyBuy.Application.Brands.Dtos;
using MediatR;

namespace EzyBuy.Application.Brands.Queries.GetBrand;

public class GetBrandQuery(int id) : IRequest<BrandDto?>
{
	public int Id { get; set; } = id;
}
