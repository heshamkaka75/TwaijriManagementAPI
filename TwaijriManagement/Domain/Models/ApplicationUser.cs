using Microsoft.AspNetCore.Identity;

namespace TwaijriManagement.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            DefaultLang = "ar";
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
        public string? FullName { get; set; }
        public string? FullNameAr { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; }
        public string DefaultLang { get; set; }
        public string? CreatedBy { get; set; }
        
    }

}
