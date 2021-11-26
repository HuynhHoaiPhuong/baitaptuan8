using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Tuan_8
{
    public class Account
    {
        private int Account_Id { get; set; }
        private String Username { get; set; }
        private String Password { get; set; }
        private String PhoneNumber { get; set; }
        private String FullName { get; set; }
        private String ImagePath { get; set; }
        private Role role { get; set; }
        private bool Status { get; set; }
    }
}
