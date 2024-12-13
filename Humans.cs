using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Humans: ISleepable
    {
        public string Name { get; set; }
        public byte Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public void See()
        {
            Console.WriteLine("Ko'ryapman...");
        }

        public void Sleep()
        {
            Console.WriteLine("Uxlayapman...");
        }
    }

}
