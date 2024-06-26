using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BCrypt.Net;

namespace PasswordHashing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
            Console.Write("1. Sign Up\n2. Log In\n\nChoose an option (1/2): ");

            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    SignUp();
                    break;
                case 2:
                    LogIn();
                    break;
                default:
                    break;
            }

            Console.ReadLine();

        }

        static void SignUp()
        {
            Console.Clear();

        }

        static void LogIn()
        {
            Console.Clear();
        }

        static string GenerateSalt()
        {
            Random RNG = new Random();
            char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string salt = "";

            ShuffleArray(ref alphabet);

            //Console.WriteLine(alphabet.Length);

            int length = RNG.Next(16, 32);

            for (int i = 0; i < length; i++)
            {
                salt = salt + alphabet[RNG.Next(0, 61)];
            }

            return salt;
        }

        static void ShuffleArray(ref char[] x)
        {
            char temp = ' ';
            Random RNG = new Random();

            for(int i=0; i<x.Length; i++)
            {
                int swap = RNG.Next(0, x.Length-1);
                temp = x[i];
                x[i] = x[swap];
                x[swap] = temp;
            }
        }
    }
}
