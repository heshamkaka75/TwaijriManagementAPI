using TwaijriManagement.Persistence.Repository;

namespace TwaijriManagement.Persistence
{
    public interface IUnitOfWork
    {

        #region Models 
        ICustomerRepository Customers { get; }
        IInvoiceRepository Invoices { get; }
        #endregion

        void Commit();
        Task CommitAsync();
    }
}
