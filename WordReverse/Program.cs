using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReverse
{
    class Program
    {
        public static char[] ReverseWord (char[] input)
        {
            char[] result = new char[input.Length];
            string buffer = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    buffer += Char.ToString(input[i]);
                }
                else
                {
                    if (buffer != "")
                    {
                        int k = i-buffer.Length;
                        for (int j=buffer.Length-1; j>=0; j--)
                        {
                            result[k] = buffer[j];
                            k++;
                        }
                    }
                    result[i] = input[i];
                    buffer = "";
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            char[] array1 = new char[] { 'H', 'e', 'l', 'l', 'o', ',', ' ', 'w', 'o', 'r', 'l', 'd', '!' };
            array1 = ReverseWord(array1);
            foreach (var e in array1)
            {
                Console.Write(e);
            }
        }
    }
}
