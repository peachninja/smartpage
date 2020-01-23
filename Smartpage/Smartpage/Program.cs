using Smartpage.Controllers;
using System;
using System.Configuration;

namespace Smartpage
{
    class Program
    {
        static void Main(string[] args)
        {

            DataController dController = new DataController();

            Console.WriteLine(dController.GetProduct(1).Name);
            Console.ReadKey();
        }
    }
}
