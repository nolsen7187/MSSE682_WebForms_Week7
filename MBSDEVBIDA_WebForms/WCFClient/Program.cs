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
            String s = proxy.AuthenticateUser("Nick");


        }
    }
}
