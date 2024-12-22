using EzyBuy.Domain.Models;

namespace EzyBuy.Domain.IRepositories;

public interface IBrandRepository : IRepository<Brand>
{
	Task<Brand> UpdateAsync(Brand obj);
}
