using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarCript
{
    internal class Cript
    {
        private static List<char> _symbols = new List<char>(); // Коллекция для хранения символов для кодировки
        private static int _shift = 3; // сдвиг шифрования
        public static void InitDictionary() // Запонит List символами для шифрования
        {            
            for (char i = ' '; i <= 'z'; i++)
            {                
                _symbols.Add(i);
            }            
            for (char i = 'А'; i <= 'я'; ++i)
            {             
                _symbols.Add(i);
            }                        
        }
        // Метод шифрования, возвращает шифрованный символ, учитывая те, которые не выдаются 
        // обычным сдвигом
        public static char Encrypt(char input) 
        {
            char result = '\0'; // пустой символ            
            int index = _symbols.IndexOf(input);
            if (index > _symbols.Count - 1 - _shift) 
            {
                result = _symbols[index%_symbols.Count];
            }
            else
            {
                result = _symbols[index + _shift];
            }
            return result;
        }
    }
}
