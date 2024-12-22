using AutoMapper;
using EzyBuy.Application.Brands.Dtos;
using EzyBuy.Domain.IRepositories;
using MediatR;

namespace EzyBuy.Application.Brands.Queries.GetBrand;

public class GetBrandQueryHandler(IMapper mapper, IBrandRepository brandRepository) :
	IRequestHandler<GetBrandQuery, BrandDto?>
{
	public async Task<BrandDto?> Handle(GetBrandQuery request, CancellationToken cancellationToken)
	{
		var brand = await brandRepository.GetAsync(b => b.Id == request.Id);
		return mapper.Map<BrandDto>(brand);
	}
}
