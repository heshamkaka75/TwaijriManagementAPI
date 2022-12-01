using System.ComponentModel.DataAnnotations;

namespace TwaijriManagement.Domain.Models
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please enter the Cutomer Name")]
        [StringLength(50)]
        [Display(Name = "Cutomer Name")]
        public string CutomerName { get; set; }
        [Required(ErrorMessage = "Please enter the agent phone")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Invoices")]
        public List<Invoice>? Invoice { get; set; }
    }
}

