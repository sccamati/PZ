using ClassLibrary.Wyjatki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class ExceptionInfo
    {
        
        public static void Wypisz(Exception wyjatek)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            if(wyjatek is SystemException)
            {
                Console.WriteLine("Wyjatek Systemowy");
            }
            else
            {
                Console.WriteLine("Wyjatek Aplikacjyjny");
            }
            Console.WriteLine($"Pelna nazwa kwalifikowana {wyjatek.GetType()}");
            Console.WriteLine($"Message: {wyjatek.Message} TargetSite: {wyjatek.TargetSite} StackTrace: {wyjatek.StackTrace} HelpLink: {wyjatek.HelpLink} Data: {wyjatek.Data}");
            
            if(wyjatek.InnerException != null)
            {
                Console.WriteLine($"InnerException: {wyjatek.InnerException}");
            }
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
       
    }
}
