using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using WCFClient.localhost;
using WCFClient.ServiceReference1;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ServiceReference1.ServicesClient client = new ServicesClient();

            //localhost.AuthenticationServices proxy = new AuthenticationServices();
            string a = client.AuthenticateUser("bob", "bob");
            string s = client.AuthenticateUser("this", "sucks");
            //localhost.AuthenticationServices proxy = new AuthenticationServices();
            //proxy.AuthenticateUser(
            //ServiceReference1.IServices proxy = new AuthenticationServices();
            Console.Out.WriteLine("right: " + a + " wrong: " + s);
            Console.ReadLine();
        }
    }
    public class WCFAuthenticationClient
    {
        public string WCFAuthUser(string weblogon, string password)
        {
            ServiceReference1.ServicesClient client = new ServicesClient();
            //WCFAuthenticationClient client = new WCFAuthenticationClient();
            
            //localhost.AuthenticationServices proxy = new AuthenticationServices();
            string a = client.AuthenticateUser(weblogon, password);
            //string s = client.AuthenticateUser("this", "sucks");
            //localhost.AuthenticationServices proxy = new AuthenticationServices();
            //proxy.AuthenticateUser(
            //ServiceReference1.IServices proxy = new AuthenticationServices();
            Console.Out.WriteLine("right: " + a);// + " wrong: " + s);
            Console.ReadLine();
            return a;
        }
    }
}
