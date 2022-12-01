namespace TwaijriManagement.Domain.Dtos.InvoiceDto
{
    public class CreateInvoiceDto
    {
        public Guid CustomerId { get; set; }
        public Decimal Value { get; set; }
    }
}
