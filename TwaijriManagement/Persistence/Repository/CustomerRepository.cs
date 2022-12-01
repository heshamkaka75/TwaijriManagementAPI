using TwaijriManagement.Domain.Models;


namespace TwaijriManagement.Persistence.Repository
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        /// Add other interface here
    }

    #region Implementation
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        /// Interface implemenation
    }
    #endregion
}


