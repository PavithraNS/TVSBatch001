using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // access modifier class className
    class Dog
    {
        //accessmodifier datatype variableName
        int age;
        int size;

        //
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
        public void Eat(int num)
        {
            Console.WriteLine("Eating");
        }
        public void Eat(float num)
        {
            Console.WriteLine("Eating");
        }
        public void Eat(float num,int n)
        {
            Console.WriteLine("Eating");
        }
        public void Eat(int num, float n)
        {
            Console.WriteLine("Eating");
        }
        public static void Run()
        {
            Console.WriteLine("Run");
        }
    }

    class Vodaphone:Dog
    {

    }
}
