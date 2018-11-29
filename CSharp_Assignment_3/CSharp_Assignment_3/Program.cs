using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharp_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account() { account_number = "AB12345362346", customer_name = "Subasree", customer_address = "XYZ", balance = 200000 };
            double Withdraw = 2000;
            double deposit = 1000;

            Bank bk = new Bank(account, Withdraw, deposit);
            Thread[] thread = new Thread[2];
            Console.WriteLine("-------------Withdraw thread---------");
            thread[0] =new Thread( new ThreadStart(bk.WithDraw));
            thread[0].Name = "Thread 0 ";
            Console.WriteLine("-------------Deposit thread---------");
            thread[1] = new Thread(new ThreadStart(bk.Deposit));
            thread[1].Name = "Thread 1 ";

            foreach (Thread t in thread)
            {
                t.Start();
            }

            Console.ReadLine();
        }
    }
}
