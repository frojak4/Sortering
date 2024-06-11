using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sortering
{
    internal class App
    {
        
        public void Run()
        { 
            int[] talliste = new int[] { 5, 3, 7, 2, 1, 9, 2 };

            var sortert = talliste
                .Where(n => n != 7)
                .Select(n => n + 1)
                .OrderBy(n => n);

            foreach (var number in sortert)
            {
                Console.WriteLine(number);
            }

        }

        

    }

}

