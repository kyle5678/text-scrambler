using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Scrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                try
                {
                    Random random = new Random();

                    for (; ; )
                    {
                        List<string> scramble = new List<string>();

                        Console.Write("Text to Scramble: ");
                        string scrambleText = Console.ReadLine();

                        foreach (char i in scrambleText)
                        {
                            scramble.Add(Convert.ToString(i));
                        }

                        string newText = "";

                        for (; 0 < scramble.Count;)
                        {
                            int rand = random.Next(0, scramble.Count);
                            newText += scramble[rand];
                            scramble.Remove(scramble[rand]);
                        }

                        Console.WriteLine($"Scrambled: \"{newText}\" \n");
                    }
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Whoops, something went wrong!");
                    Console.WriteLine(e);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
    }
}
