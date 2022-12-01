namespace TwaijriManagement.Domain.Dtos.InvoiceDto
{
    public class UpdateInvoiceDto
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public decimal Value { get; set; }
        public int State { get; set; }

    }
}
