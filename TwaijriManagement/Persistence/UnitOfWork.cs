using TwaijriManagement.Persistence.Repository;

namespace TwaijriManagement.Persistence
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        #region Models 
        public ICustomerRepository Customers { get; private set; }
        public IInvoiceRepository Invoices { get; private set; }
        #endregion
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this._context = dbContext;
            Customers = new CustomerRepository(_context);
            Invoices = new InvoiceRepository(_context);
        }

        public void Commit()
        {
            this._context.SaveChanges();
        }

        
        public async Task CommitAsync()
        {
            await this._context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
