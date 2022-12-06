using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat gato = new Cat
            {
                Breed = "Cyprus",
                Size = 12,
            };
            gato.Sound();
            gato.ShowBreed();
            gato.ShowSize();
        }
    }
}
