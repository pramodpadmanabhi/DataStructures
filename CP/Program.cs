using System;
using System.Collections;

namespace CP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //longestCommonPrefix();
            
            Stack stack = new Stack();
            TLG();
        }


        public static void longestCommonPrefix()
        {
            string[] args = new string[3];
            args[0] = "flower";
            args[1] = "flow";
            args[2] = "fl";
            if (args.Length == 0) Console.WriteLine("");
            var prefix = args[0];
            for (int i = 1; i < args.Length; i++)
            {

                while (args[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "") Console.WriteLine("");
                }

            }
            Console.WriteLine(prefix);
            Console.ReadKey();
        }

        public static void TLG()
        {
            var inputCount = Console.ReadLine();
            var t = int.Parse(inputCount);

            var cumScoreA = 0;
            var cumScoreB = 0;
            var highestLead = 0;
            var player = 1;
            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine();
                var scores = input.Split(' ');
                var scoreA = int.Parse(scores[0]);
                var scoreB = int.Parse(scores[1]);
                cumScoreA += scoreA;
                cumScoreB += scoreB;
                var diff = cumScoreA - cumScoreB;
                var lead = Math.Abs(diff);
                if (lead > highestLead)
                {
                    highestLead = lead;
                    player = diff >= 0 ? 1 : 2;
                }
            }

            Console.WriteLine($"{player} {highestLead}");

        }
    }
}
