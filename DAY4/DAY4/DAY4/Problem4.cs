using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4
{
    internal class Problem4
    {
        public void Run()
        {
            string[] readPhones = Console.ReadLine().Split(' ');
            string[] readBrowers = Console.ReadLine().Split(' ');
            Phone phone = new Phone();
            phone.CallPhone(readPhones);
            phone.Browser(readBrowers);
        }
    }
    class Phone : CallOtherPhone, Browsing
    {
        public void CallPhone(string[] phones)
        {
            foreach (var phone in phones)
            {
                if (phone != null) Console.WriteLine($"Calling... {phone}");
                else Console.WriteLine($"Invalid Phone Number !!!");
            }
        }
        public void Browser(string[] sites)
        {
            foreach (var site in sites)
            {
                if (site.Any(char.IsDigit)) {
                    Console.WriteLine("Invalid URL!");
                    continue;
                } else if (!site.Any(char.IsDigit)) Console.WriteLine($"Browsing: {site}");

            }
        }
    }
    interface CallOtherPhone 
    {
        void CallPhone(string[] phones);
    }
    interface Browsing
    {
        void Browser(string[] sites);
    }
}
