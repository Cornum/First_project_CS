using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();

            countriesCapitals.Add("Australia", "Canberra");
            countriesCapitals.Add("Turkey", "Ancara");
            countriesCapitals.Add("Sweden", "Bern");
            countriesCapitals.Remove("Turkey");

            foreach(var item in countriesCapitals)
            {
                Console.WriteLine($"Country - {item.Key}. Capital - {item.Value}");
            }
            foreach(var key in countriesCapitals.Keys)
            {
                Console.WriteLine($"Country - {key}.");
            }
            foreach (var value in countriesCapitals.Values)
            {
                Console.WriteLine($"Capital - {value}");
            }
            /*if (countriesCapitals.ContainsKey("Australia"))
            Console.WriteLine(countriesCapitals["Australia"]);*/

        }
    }
}

