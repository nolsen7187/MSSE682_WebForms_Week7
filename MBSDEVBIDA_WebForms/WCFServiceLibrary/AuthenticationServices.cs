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
       // private bool logonFound, passwordFound;

        public string AuthenticateUser(string logon, string password)
        {
            /*SVC_AuthenticateUser svcAuthenticateUser = new SVC_AuthenticateUser();
            logonFound = svcAuthenticateUser.AuthenticateLogon(logon);
            passwordFound = svcAuthenticateUser.AuthenticatePassword(password);
            
            if ((logonFound && passwordFound) == true)
            {*/
                return "true";
            /*}
            else
            {
                return false;
            }*/
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public string Hello(string name)
        {
            return "Hello " + name;
        }
    }
}
