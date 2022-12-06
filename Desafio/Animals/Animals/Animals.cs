using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animals
    {
        public string Breed { get; set; }
        public double Size { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("I am an animal!\n");
        }

        public void ShowBreed()
        {
            Console.WriteLine($"Breed: {Breed}\n");
        }

        public void ShowSize()
        {
            Console.WriteLine($"Size: {Size} inches\n");
        }
    }
}
