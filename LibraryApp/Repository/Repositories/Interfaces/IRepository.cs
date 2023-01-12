using System;
using Domain.Common;

namespace Repository.Repositories.Interfaces
{
	public interface IRepository<T> where T: BaseEntity
	{
		void Create(T entity);
		void Delete(T entity);
		void Update(T entity);
		T Get(Predicate<T> predicate);
		List<T> GetAll(Predicate<T> predicate);
	}
}