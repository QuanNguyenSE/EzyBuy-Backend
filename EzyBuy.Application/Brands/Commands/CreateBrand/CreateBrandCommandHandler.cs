using AutoMapper;
using EzyBuy.Domain.IRepositories;
using EzyBuy.Domain.Models;
using MediatR;

namespace EzyBuy.Application.Brands.Commands.CreateBrand;

public class CreateBrandCommandHandler(IMapper mapper, IBrandRepository brandRepository) : 
	IRequestHandler<CreateBrandCommand, int>
{
	public async Task<int> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
	{
		var brand = mapper.Map<Brand>(request);
		await brandRepository.CreateAsync(brand);
		await brandRepository.SaveAsync();
		return brand.Id;
	}
}
