using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WCFClient.localhost;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.AuthenticationServices proxy = new AuthenticationServices();
            proxy.AuthenticateUser("test", "pass");
            //localhost.AuthenticationServices proxy = new AuthenticationServices();
            //proxy.AuthenticateUser(
            //ServiceReference1.IServices proxy = new AuthenticationServices();
            


        }
    }
}
