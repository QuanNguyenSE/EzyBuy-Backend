using AutoMapper;
using EzyBuy.Application.Brands.Dtos;
using EzyBuy.Domain.IRepositories;
using MediatR;

namespace EzyBuy.Application.Brands.Queries.GetAllBrands;

public class GetAllBrandsQueryHandler(IMapper mapper, IBrandRepository brandRepository) :
	IRequestHandler<GetAllBrandsQuery, IEnumerable<BrandDto>>
{
	public async Task<IEnumerable<BrandDto>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
	{
		var brands = await brandRepository.GetAllAsync();
		return mapper.Map<IEnumerable<BrandDto>>(brands);
	}
}
