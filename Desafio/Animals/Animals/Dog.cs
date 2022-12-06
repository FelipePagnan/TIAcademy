using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animals
    {
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Woof!\nAnd I am also a dog\n");
        }
    }
}
