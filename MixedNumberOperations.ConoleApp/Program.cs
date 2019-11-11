using System;
using System.Linq;

namespace MixedNumberOperations.ConoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            bool quitNow = false;
            while (!quitNow)
            {
                Console.Write("input: ");
                command = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(command))
                {
                    continue;
                }

                command = command.Trim();
                if (command.ToLower() == "quit")
                {
                    break;
                }

                var inputs = command.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x));
                if(inputs.Count() != 3)
                {
                    Console.WriteLine("Incorrect input");
                    continue;
                }

                var ipArray = inputs.ToArray();
                if(ipArray[1] != "+" && ipArray[1] != "-" && ipArray[1] != "*" && ipArray[1] != "/")
                {
                    Console.WriteLine("Incorrect input");
                    continue;
                }

                try
                {
                    var one = new MixedNumber(ipArray[0]);
                    var two = new MixedNumber(ipArray[2]);

                    var result = string.Empty;
                    switch (ipArray[1])
                    {
                        case "+":
                            result = MixedNumberHelper.Add(one, two).ToString();
                            break;
                        case "-":
                            result = MixedNumberHelper.Subtract(one, two).ToString();
                            break;
                        case "*":
                            result = MixedNumberHelper.Multiply(one, two).ToString();
                            break;
                        case "/":
                            result = MixedNumberHelper.Divide(one, two).ToString();
                            break;
                    }

                    Console.WriteLine("output: {0}", result);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
