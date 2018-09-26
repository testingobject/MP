using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ManpowerManagement.ViewModel
{
    public class UserViweModel
    {
        [Required(ErrorMessage = "FirstName is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LasttName is Required")]
        public string LasttName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Email Address is not valid")]
        public string Email { get; set; }

        public string UserName { get; set; }
        [Required(ErrorMessage = "MobileNumber is Required")]
        public string MobileNumber { get; set; }

        public bool IsEmailVerified { get; set; }
        public int UserRole { get; set; }
        public string ProfileImage { get; set; }
    }
}
