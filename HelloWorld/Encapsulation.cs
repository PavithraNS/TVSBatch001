using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Encapsulation
    {
        private int age;

        public void SetMethod(int number)
        {
            if(number>0)
            {
                age = number;
            }
           
        }
        public void Display()
        {
            Console.WriteLine(age);
        }
    }
}
