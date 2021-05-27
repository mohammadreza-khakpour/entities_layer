using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Attendance.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public Mobile Mobile { get; set; }
        public UserTimeZone UserTimeZone { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime CreationDate { get; set; }
    }
    public class Mobile
    {
        public string CountryCallingCode { get; set; }
        public string MobileNumber { get; set; }
    }

    public class UserTimeZone
    {
        public string ZoneName { get; set; }
        public string LanguageCode { get; set; }

        public UserTimeZone(string zoneName, string languageCode)
        {
            ZoneName = zoneName;
            LanguageCode = languageCode;
        }
    }
    public class ApplicationRole : IdentityRole<Guid>
    {
    }
    public class ApplicationUserRole : IdentityUserRole<Guid>
    {
    }
    public class ApplicationUserClaim : IdentityUserClaim<Guid>
    {
    }
    public class ApplicationUserLogin : IdentityUserLogin<Guid>
    {
    }
    public class ApplicationRoleClaim : IdentityRoleClaim<Guid>
    {
    }
    public class ApplicationUserToken : IdentityUserToken<Guid>
    {
    }

    public struct SystemRoles
    {
        public const string Admin = "Admin";
        public const string Employee = "Employee";
        public const string Supervisor = "Supervisor";
    }
}
