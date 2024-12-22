using EzyBuy.Application.Brands.Commands.CreateBrand;
using EzyBuy.Application.Brands.Queries.GetAllBrands;
using EzyBuy.Application.Brands.Queries.GetBrand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EzyBuy.API.Controllers;

[Route("api/brand")]
[ApiController]
public class BrandController(IMediator mediator) : ControllerBase
{
	[HttpGet]
	public async Task<IActionResult> GetBrands()
	{
		var brands = await mediator.Send(new GetAllBrandsQuery());
		return Ok(brands);
	}
	[HttpGet("{id}")]
	public async Task<IActionResult> GetBrand([FromRoute] int id)
	{
		var brand = await mediator.Send(new GetBrandQuery(id));
		if (brand == null)
		{
			return BadRequest();
		}
		return Ok(brand);
	}
	[HttpPost]
	public async Task<IActionResult> CreateBrand([FromBody] CreateBrandCommand command)
	{
		var id = await mediator.Send(command);
		return CreatedAtAction(nameof(GetBrand), new { id }, null);
	}
}
