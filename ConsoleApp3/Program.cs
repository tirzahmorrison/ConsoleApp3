using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; 
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mapper = new MorseMapper(args[0]);
            var input = "";

            while (true)
            {
                Console.WriteLine("Type the sentence you would like to convert to morse. Press Enter to quit.");
                input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                var converted = Mapper.AlphaMorph(input);
                Console.WriteLine("Your sentence has been encrypted to {0}", converted);
                Console.WriteLine("If you want to continue type y if you want to quit type n");
                input = Console.ReadLine();
                if(input.ToLower() == "n")
                {
                    break;
                }
            } 

        }
    }
}