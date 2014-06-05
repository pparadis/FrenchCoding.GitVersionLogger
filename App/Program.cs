using System;
using System.Linq;
using System.Reflection;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var descriptionAttribute = Assembly.GetExecutingAssembly()
                .GetCustomAttributes(typeof(AssemblyTitleAttribute), false)
                .OfType<AssemblyTitleAttribute>()
                .FirstOrDefault();

            if (descriptionAttribute != null)
            {
                Console.WriteLine(descriptionAttribute.Title);
            }
            Console.ReadKey();
        }
    }
}
