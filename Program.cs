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
            Console.WriteLine("Input A Password To Be Checked");
            
            //Get user Input
            var UserInput = Console.ReadLine();
            var SecurityCount = 0;
            Regex pattern = new Regex(@"\W|_");
            
            //Check length of input 
            if (UserInput.Length >=7)
            {
                SecurityCount++;
                
            } else
                {
                SecurityCount--;
                 }

            

            //Checks for the same 2 characters next to each other and outputs warning if needed
            for (int i = 0; i < UserInput.Length - 1; i++)
            {
                if (UserInput[i] == UserInput[i + 1])
                    
                    Console.WriteLine("WARNING: 2 characters of the same type should not be paired together in a password");
                
            }
            
            //Checks for special characters
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char c in specialCharactersArray)
            {
                if (UserInput.Contains(c))
                    SecurityCount++;
            }
            
            //Outputs score
            Console.WriteLine("Your Security Score Out of 7 is: " + SecurityCount);
            


        }
    }
}
