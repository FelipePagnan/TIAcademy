using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Bird : Animals
    {
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Tweet!\nAnd I am also a bird\n");
        }
    }
}
