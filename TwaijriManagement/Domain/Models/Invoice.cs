using System.ComponentModel.DataAnnotations;
using TwaijriManagement.Domain.Enums;

namespace TwaijriManagement.Domain.Models
{
    public class Invoice
    {
        public Invoice()
        {
            Id = Guid.NewGuid();
            State = ((int)States.New);
            InvoiceDate = DateTime.Now;
            CreatedBy = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public Guid? CustomerID { get; set; }
        public Customer Customer { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Invoice Date")]
        public DateTime InvoiceDate { get; set; }
        public decimal Value { get; set; }
        public int State { get; set; }
        public Guid CreatedBy { get; set; }
    }
}

