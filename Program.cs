using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarCript
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Привет!";
            Cript.InitDictionary();
            string cryptoText = "";
            foreach (var item in text)
            {
                cryptoText += Cript.Encrypt(item);
            }
            Console.WriteLine(text);
            Console.WriteLine(cryptoText);
        }
    }
}
