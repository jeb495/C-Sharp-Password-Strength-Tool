using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace PassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This password checker ranks a password based on character length, as well as number of special characters");
            Console.WriteLine("");
            Console.WriteLine("Input A Password To Be Checked");
            var UserInput = Console.ReadLine();
            var SecurityCount = 0;
            Regex pattern = new Regex(@"\W|_");

            if (UserInput.Length >=7)
            {
                //SecurityCount--;
                
            } else
                {
                SecurityCount--;
                 }

            if (UserInput.Length <7)
            {
                SecurityCount--;
            }

            for (int i = 0; i < UserInput.Length - 1; i++)
            {
                if (UserInput[i] == UserInput[i + 1])
                    
                    Console.WriteLine("WARNING: 2 characters of the same type should not be paired together in a password");
                
            }

            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char c in specialCharactersArray)
            {
                if (UserInput.Contains(c))
                    SecurityCount++;
            }
;
            Console.WriteLine("Your Security Score Out of 7 is: " + SecurityCount);
            Console.WriteLine(" ");
            Console.WriteLine("The more random the password, the better");


        }
    }
}
