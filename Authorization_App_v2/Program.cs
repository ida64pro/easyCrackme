using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Globalization;

namespace Authorization_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // URL web site. 
            string url = "https://pastebin.com/raw/AYKJs4Cd";
            string text = "null";
            try
            {
                // Create example Weblient
                using (WebClient client = new WebClient())
                {
                    // Set encode UTF-8
                    client.Encoding = System.Text.Encoding.UTF8;

                    // Reading text from web-site.
                    text = client.DownloadString(url);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception, try later. Error: " + ex);
            }
            // Creat cycle to indefinitely again.
            for (;;)
            {
                Console.Write("Enter password: ");
                string v = Console.ReadLine();
                string password = v;

                if (password == text)
                {
                    // if password correctly
                    Console.WriteLine("Success.");
                    break;
                }
                else
                {
                    // if password incorrect
                    Console.WriteLine("Password incorrect.");
                }
            }
            Console.ReadKey();
        }
    }
}