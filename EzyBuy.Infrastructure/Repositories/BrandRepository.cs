using EzyBuy.Domain.IRepositories;
using EzyBuy.Domain.Models;
using EzyBuy.Infrastructure.Data;

namespace EzyBuy.Infrastructure.Repositories;

internal class BrandRepository(ApplicationDbContext db) : 
	Repository<Brand>(db), IBrandRepository
{
	public async Task<Brand> UpdateAsync(Brand obj)
	{
		db.Brands.Update(obj);
		return obj;
	}
}
