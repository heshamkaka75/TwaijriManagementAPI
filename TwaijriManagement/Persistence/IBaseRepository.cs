using System.Linq.Expressions;

namespace TwaijriManagement.Persistence
{
    public interface IBaseRepository<T>
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void UpdateAsync(T entity);
        void UpdateRangeAsync(List<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        T Get(Expression<Func<T, bool>> expression);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        IQueryable<T> GetMany(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Include(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeExpressions);
        Task<IEnumerable<T>> ExcuteQuerys(string query, params object[] parameters);
        public Task<dynamic> ExcuteQuery(string query, params object[] parameters);
        public Task<dynamic> ExcuteQueryList(string query, params object[] parameters);
    }
}
