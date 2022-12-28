using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Cat : Animal
    {
        private string name;
        private string voice;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Cat(string name, string voice)
            : base(name)
        {
            this.voice = voice;
        }

        public override void Say()
        {
            Console.WriteLine(voice);
        }
    }
}
