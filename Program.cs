using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        //Deklarieren
        static Func<string> l1;

        static void Main(string[] args)
        {
            //Initalisieren
            l1 = lange;

            //Asynchroner Aufruf mit BeginInvoke
            IAsyncResult result = l1.BeginInvoke(new AsyncCallback(delegate(IAsyncResult r) { Console.WriteLine(l1.EndInvoke(r)); } ), null);
            

            Console.WriteLine("Wenn das zuerst kommt blockiert nicht! :)");
           


            Console.ReadKey();
        }
        

        static string lange()
        {
            Thread.Sleep(3000);
            Console.WriteLine();
            return "Bin fertig";
        }



    }
}
