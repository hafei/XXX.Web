using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XXX.Web.Interfaces;

namespace XXX.Web.Services
{
    public class FormsAuthenticationService  :IFormsAuthenticationService
    {
        public void SignIn(string userName, bool createPersistentCookie)
        {
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }
    }
}