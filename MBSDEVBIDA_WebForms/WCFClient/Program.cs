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
            string a = proxy.AuthenticateUser("bob", "bob");
            string s = proxy.AuthenticateUser("this", "sucks");
            //localhost.AuthenticationServices proxy = new AuthenticationServices();
            //proxy.AuthenticateUser(
            //ServiceReference1.IServices proxy = new AuthenticationServices();
            Console.Out.WriteLine("right: " + a + " wrong: " + s);
            Console.ReadLine();
        }
    }
}
