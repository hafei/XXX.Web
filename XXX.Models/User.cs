using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XXX.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string BlogID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime LastLoginTime { get; set; }

        public string EmailAddress { get; set; }
    }
}
