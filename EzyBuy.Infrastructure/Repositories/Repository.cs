using EzyBuy.Domain.IRepositories;
using EzyBuy.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EzyBuy.Infrastructure.Repositories;

internal class Repository<T> : IRepository<T> where T : class
{
	private readonly ApplicationDbContext _db;
	internal DbSet<T> _dbSet;

    public Repository(ApplicationDbContext db)
    {
		_db = db;
		_dbSet = _db.Set<T>();
	}

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, bool tracking = true, string? includeProperties = null)
	{
		IQueryable<T> query = _dbSet;

		if (filter != null)
		{
			query = query.Where(filter);
		}
		if (!tracking)
		{
			query = query.AsNoTracking();
		}
		if (includeProperties != null)
		{
			foreach (var property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
			{
				query = query.Include(property);
			}
		}
		return await query.ToListAsync();
	}

	public async Task<T?> GetAsync(Expression<Func<T, bool>>? filter = null, bool tracking = true, string? includeProperties = null)
	{
		IQueryable<T> query = _dbSet;
		if (filter != null)
		{
			query = query.Where(filter);
		}
		if (!tracking)
		{
			query = query.AsNoTracking();
		}
		if (includeProperties != null)
		{
			foreach (var property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
			{
				query = query.Include(property);
			}
		}
		return await query.FirstOrDefaultAsync();
	}
	public async Task CreateAsync(T entity)
	{
		await _dbSet.AddAsync(entity);
	}

	public Task RemoveAsync(T entity)
	{
		_dbSet.Remove(entity);
		return Task.CompletedTask;
	}

	public async Task SaveAsync()
	{
		await _db.SaveChangesAsync();
	}
}
