using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    internal class Cat : Animal
    {
        public new void Eat() { Console.WriteLine("예쁘게 먹습니다."); }
        public new void Sleep() { Console.WriteLine("소곤소곤 잠을 잡니다."); }
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
    }
}
