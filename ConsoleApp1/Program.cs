using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DBDataContext data = new DBDataContext();
            var products = from product in data.tblproduct8s
                           select product;
            //var a = products;
            Console.Write(typeof());
        }
    }
}
