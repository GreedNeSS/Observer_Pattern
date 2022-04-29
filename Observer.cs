using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class Observer
    {
        public void ShowUpdateUserStatus(string name, string status)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"User: {name}, Status: {status}");
            Console.ResetColor();
        }
    }
}
