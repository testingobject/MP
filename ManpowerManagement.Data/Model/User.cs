using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ManpowerManagement.Data.Model
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        
        public string Email { get; set; }

        public string UserName { get; set; }
        public string MobileNumber { get; set; }
        public bool IsEmailVerified { get; set; }
        public int UserRole { get; set; }
        public string ProfileImage { get; set; }
    }
}
