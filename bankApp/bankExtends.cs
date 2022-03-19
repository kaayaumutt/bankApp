using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankApp
{
    public class bankExtends : bankProcess
    {
        //Crushing(ezme)
        public new void Welcome()
        {
            Console.WriteLine("Hoş geldin {0} {1} kimlik no'n:{2} bakiyen:{3} -- bankExtends", this.name, this.surName, this.tcNo, this.balance);
        }

        //Method Overloading(aşırı yükleme)
        public void Welcome(bool overLoad)
        {
            Console.WriteLine("Method Overloading(Bu fonksiyona aşırı yüklendin!)!");
        }

        public void extendsConstants()
        {
            Console.WriteLine("----SABİTLER------");
            Console.WriteLine("Evet Hayır Soru Sabiti _yes = {0}",_yes);
            Console.WriteLine("İyi günler sabiti _bye = {0}", _bye);
            Console.WriteLine("Tc no karakter sabiti _tcNoLength = {0}", _tcNoLength);
            Console.WriteLine("Tc no ilk karakter sabiti _tcNoFirstCharacter = {0}", _tcNoFirstCharacter);
        }
    }
}
