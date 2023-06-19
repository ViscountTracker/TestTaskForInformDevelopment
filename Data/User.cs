using Microsoft.AspNetCore.Identity;

namespace TestTaskForInformDevelopment.Data
{
    public class User : IdentityUser
    {
        public string Name {get;set;}
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal InitialPropertyValue { get; set; }
        public decimal CurrentPropertyValue { get; set;}
    }
 
}
