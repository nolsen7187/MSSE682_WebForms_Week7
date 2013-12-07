using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using SVC;

namespace WCFServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AuthenticationServices : IServices
    {
        private bool logonFound, passwordFound;

        public bool AuthenticateUser(string logon, string password)
        {
            SVC_AuthenticateUser svcAuthenticateUser = new SVC_AuthenticateUser();
            logonFound = svcAuthenticateUser.AuthenticateLogon(logon);
            passwordFound = svcAuthenticateUser.AuthenticatePassword(password);

            if ((logonFound && passwordFound) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
