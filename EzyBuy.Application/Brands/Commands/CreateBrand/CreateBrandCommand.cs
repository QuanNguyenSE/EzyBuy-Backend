using MediatR;

namespace EzyBuy.Application.Brands.Commands.CreateBrand;

public class CreateBrandCommand : IRequest<int>
{
	public string Name { get; set; } = default!;
}
