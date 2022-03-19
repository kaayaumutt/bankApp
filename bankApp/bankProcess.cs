using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankApp
{
    public class bankProcess
    {
        public string name;
        public string surName;
        public string tcNo;
        public double balance;
        public double withDraw;

        public const string _yes= "E";
        public const string _bye = "İyi günler..";
        public const byte _tcNoLength = 11;
        public const char _tcNoFirstCharacter = '0';

        public void Welcome()
        {
            Console.WriteLine("Hoş geldin {0} {1} kimlik no'n:{2} bakiyen:{3}", this.name,this.surName,this.tcNo,this.balance);
        }

        public void bankWithdraw(double withDraw)
        {
            if (tcnoControl())
            {
                Welcome();
                this.withDraw=withDraw;
                if (this.balance>=withDraw)
                {
                    Console.WriteLine("Girilen tutar {0} çekebilirsiniz.", withDraw);
                    withDrawQuestion();
                }
                else
                {
                    Console.WriteLine("Girilen tutar {0} bakiyenizden {1} yüksek..", withDraw, withDraw-this.balance);
                    addBalanceQuestion();
                }
            }
            else
            {
                Console.WriteLine("{0} Tcno yanlış!",this.tcNo);
                bye();
            }
        }

        public void remainderBalance()
        {
            Console.WriteLine("{0} lira çektiniz ,Kalan bakiyeniz {1}",this.withDraw, this.balance-this.withDraw);
        }

        public void withDrawQuestion()
        {
            Console.WriteLine("Parayı çekmek istiyormusun?(e/h)");
            string result = Console.ReadLine();
            if (yesnoQuestion(result))
            {
                remainderBalance();
            }
            else
            {
                bye();
            }
        }

        public void addBalanceQuestion()
        {
            Console.WriteLine("Bakiye eklemek istiyormusunuz?(e/h)");
            string result = Console.ReadLine();
            if (yesnoQuestion(result))
            {
                addBalance();
            }
            else
            {
                bye();
            }
        }

        public bool yesnoQuestion(string result)
        {
            bool skip = false;
            if(result==_yes || result==_yes.ToLower())
            {
                skip = true;
            }
            else{ skip = false; }
            return skip;
        }

        public void addBalance()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Eklenecek Tutarı Giriniz: ");
                    int result = int.Parse(Console.ReadLine());
                    this.balance = this.balance+result;
                    Console.Clear();
                    bankWithdraw(this.withDraw);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Yanlış formatta girdiniz tekrar deneyin.");
                }
            }
        }

        public void bye()
        {
            Console.WriteLine(_bye);
        }

        public bool tcnoControl()
        {
            bool skip = false;
            if(this.tcNo.Length==_tcNoLength && this.tcNo[0]!=_tcNoFirstCharacter)
            {
                foreach(char c in this.tcNo)
                {
                    if (Char.IsNumber(c))
                    {
                        skip = true;
                    }
                    else
                    {
                        skip = false;
                        break;
                    }
                }
            }
            else { skip = false; }
            return skip;
        }

    }
}
