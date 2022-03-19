using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title="KAYA BANK";
            
            bankProcess bank = new bankProcess();
            bank.name = "UMUT";
            bank.surName = "KAYA";
            bank.tcNo = "16542348253";
            bank.balance = 500;
            bank.bankWithdraw(600);

            bankExtends bankExtends = new bankExtends();
            bankExtends.name = "TAHA";
            bankExtends.surName = "KAYA";
            bankExtends.tcNo ="16542348253";
            bankExtends.balance = 600;
            bankExtends.Welcome();
            bankExtends.Welcome(true);
            bankExtends.Welcome(false);
            bankExtends.extendsConstants();

            Console.Read();
        }
    }
}
