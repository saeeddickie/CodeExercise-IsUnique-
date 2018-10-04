using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview1._1_IsUnique_
{
    class Program
    {
        static void Main(string[] args)
        {

            string example = "tests";


            char[] characters = example.ToCharArray();
            char[] characterscompare = example.ToCharArray();
            int charactercomparelength = (characterscompare.Length) - 1;
            List<char> duplicatedcharacters = new List<char>();

            bool isUnique = true;

            for (int i = 0; i < characters.Length; i++)
            {
                char character = Char.ToLower(characters[i]);

                for (int j = charactercomparelength; j >= 0; j--)
                {
                    char charactercompare = Char.ToLower(characterscompare[j]);

                    if (character == charactercompare)
                        {

                          if (j != i)
                            {
                              isUnique = false;
                            duplicatedcharacters.Add(character);

                            }
                          }
    }

}

            if (isUnique)
            {
                Console.Out.Write("String: " + example +"\n");
                Console.Out.Write("The example above contains unique characters");
            }
            else
            {
                Console.Out.Write("String: " + example + "\n");
                Console.Out.Write("The example above does not contain unique characters" + "\n");
              
                Console.Out.Write("The duplicated characters are:- \n");
      

                foreach (char character in duplicatedcharacters)
                {
                    Console.Out.Write(character + "\n");
              
                }

            }

          //  Console.Out.WriteLine("Test");

            Console.ReadLine();
        }
    }
}
