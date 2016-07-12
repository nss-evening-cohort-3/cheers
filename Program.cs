using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Variables section
            String prompt = "> ";
            String cheer_prefix = "Give me a";
            String requires_an = "aeiolnfshrmx";


            Console.WriteLine("What's your name?");
            Console.Write(prompt);
            String user_name = Console.ReadLine().ToLower(); // Read from terminal save to a variable


            // First Refactoring removing the 'else'
            /* 
            for(int i = 0; i < user_name.Length; i++) {
                String cheer_prefix = "Give me a"; // Resets the cheer_prefix variable every iteration through for loop
                if (requires_an.IndexOf(user_name[i]) > -1) {
                    cheer_prefix += "n";
                }
                Console.WriteLine(cheer_prefix + ".. " + user_name[i]);

            }
            */



            // Last Refactoring using Contains instead of 'IndexOf'

            for(int i = 0; i < user_name.Length; i++) {
                if (requires_an.Contains(user_name[i])) { // Performs implicit casting from Char to String
                    Console.WriteLine(cheer_prefix + "n" + ".. " + user_name[i]);
                } else {
                    Console.WriteLine(cheer_prefix + ".. " + user_name[i]);
                }
            }



            // Original Solution, using 'IndexOf'
            /* 
            for(int i = 0; i < user_name.Length; i++) {
                if (requires_an.IndexOf(user_name[i]) > -1) {
                    // Then it's in the requires_an array!!!!
                    Console.WriteLine(cheer_prefix + "n" + ".. " + user_name[i]);
                } else {
                    // Does not require an "an"
                    Console.WriteLine(cheer_prefix + ".. " + user_name[i]);
                }
            }
            */

            // user_name.ToUpper() is turning the the user's name to uppercase.
            // ToUpper() is functionality specific to Strings.
            // ToUpper() accepts no arguments

            Console.WriteLine(user_name.ToUpper() + " is.. GRAND!"); //
        }
    }
}
