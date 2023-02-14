using System;

namespace ROT13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena para descifrar ROT13:");
            string input = Console.ReadLine();
            Console.WriteLine("La cadena descifrada es: " + Rot13(input));
            Console.ReadLine();
        }

        static string Rot13(string input)
        {
            char[] charArray = input.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                int charValue = (int)charArray[i];
                if (charValue >= 'a' && charValue <= 'z')
                {
                    if (charValue > 'm')
                    {
                        charValue -= 13;
                    }
                    else
                    {
                        charValue += 13;
                    }
                }
                else if (charValue >= 'A' && charValue <= 'Z')
                {
                    if (charValue > 'M')
                    {
                        charValue -= 13;
                    }
                    else
                    {
                        charValue += 13;
                    }
                }
                charArray[i] = (char)charValue;
            }
            return new string(charArray);
        }
    }
}
