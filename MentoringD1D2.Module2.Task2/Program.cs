using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentoringD1D2.Module2.Task2.Extensions;
using MentoringD1D2.Module2.Task2.Extensions.Enums;

namespace MentoringD1D2.Module2.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings =
            {
                "quiy",
                null,
                "do",
                null,
                "winter",
                "deLimeter",
                "121_number",
                "wonderful",
                "air",
                "История",
                "string",
                "stringExample",
                "mark",
                "человек",
                "902 ^bb",
                "#$!",
                "Da"
            };

            List<string> listOfStrings = new List<string>
            {
                "quiy",
                null,
                "do",
                null,
                "winter",
                "deLimeter",
                "121_number",
                "wonderful",
                "air",
                "История",
                "string",
                "stringExample",
                "mark",
                "человек",
                "902 ^bb",
                "#$!",
                "Da"
            };
            string[] arraStrings = new string[] {};
            arraStrings.CustomSort();
            listOfStrings.Sort();
            Console.WriteLine("-----------Existing sort----------");
            listOfStrings.ForEach(Console.WriteLine);
            Console.WriteLine("-----------Custom sort------------");
            foreach (var element in arraStrings.CustomSort())
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
