using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class CeasarCipher
    {
        public CeasarCipher()
        {
            var cipheredMsg = cipherMsg(3, "attack");
            decipherMsg(3, cipheredMsg);
        }

        StringBuilder resultBuilder = new StringBuilder();
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g',
                'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
                't', 'u', 'v', 'w', 'x', 'y', 'z' };

        private string cipherMsg(int rotaNumber, string msg)
        {
            char[] msgCharArray = msg.ToCharArray();
            resultBuilder.Clear();
            foreach (char letter in msgCharArray)
            {
                int letterIndex = Array.IndexOf(alphabet, letter);
                resultBuilder.Append(alphabet[letterIndex + rotaNumber]);
            }
            Console.WriteLine(resultBuilder.ToString());
            return resultBuilder.ToString();
        }

        private string decipherMsg(int rotaNumber, string msg)
        {
            char[] msgCharArray = msg.ToCharArray();
            resultBuilder.Clear();
            foreach (char letter in msgCharArray)
            {
                int letterIndex = Array.IndexOf(alphabet, letter);
                resultBuilder.Append(alphabet[letterIndex - rotaNumber]);
            }
            Console.WriteLine(resultBuilder.ToString());
            return resultBuilder.ToString();
        }


    }
}
