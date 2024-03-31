using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment4
{
    internal class AverageArray
    {
        List<double> numbers = new List<double>();

        public void AddNumbers()
        {
            int number = -1;

            do
            {
                Console.WriteLine("Mata in ett heltall");
                string userinput = Console.ReadLine();
                bool okey = int.TryParse(userinput, out number);
                if(okey)
                {
                    if (number >0)
                    numbers.Add(number);
                }
                Console.WriteLine("Medelvärdet är: "+ Math.Round(numbers.Average(), 2));

            } while (number !=0);

        }
    }
}
