using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animals
    {
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Meow!\nAnd I am also a cat\n");
        }
    }
}
