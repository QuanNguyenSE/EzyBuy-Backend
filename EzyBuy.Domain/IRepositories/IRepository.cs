using System.Linq.Expressions;

namespace EzyBuy.Domain.IRepositories;

public interface IRepository<T> where T : class
{
	Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, bool tracking = true, string? includeProperties = null);
	Task<T?> GetAsync(Expression<Func<T, bool>>? filter = null, bool tracking = true, string? includeProperties = null);
	Task CreateAsync(T entity);
	Task RemoveAsync(T entity);
	Task SaveAsync();
}
