using BUS.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            String pass = PasswordMD5.Encrypt("123456789");
            Console.WriteLine(pass);
            Console.WriteLine(PasswordMD5.Decrypt(pass));
            Console.ReadLine();
        }
    }
}
