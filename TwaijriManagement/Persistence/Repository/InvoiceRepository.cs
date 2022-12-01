using TwaijriManagement.Domain.Models;

namespace TwaijriManagement.Persistence.Repository
{
    public interface IInvoiceRepository : IBaseRepository<Invoice>
    {
        /// Add other interface here
    }

    #region Implementation
    public class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        /// Interface implemenation
    }
    #endregion
}


