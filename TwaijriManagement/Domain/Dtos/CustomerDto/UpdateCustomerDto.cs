using TwaijriManagement.Domain.Models;

namespace TwaijriManagement.Domain.Dtos.CustomerDto
{
    public class UpdateCustomerDto
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
