using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAZ.Course2022.FirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null) {
                line = line.Replace('h', 'p');
                line = "Privet" + line;
                Console.WriteLine(line);
            }
            
        }
    }
}
