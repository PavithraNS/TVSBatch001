using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    /// <summary>
    /// creating BestCoding sample class
    /// </summary>
 
    public class Program
    {
        //instance variable
        int numberTest=12;
        
        static int number1=10;

        //folowing pascal case for both class and method
        public void TestMethod()
        {
            string name="XYZ";
            number1 = 20;
            Console.WriteLine(name);
        }
    }

    public class Drawing
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    public class Circle : Drawing
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 5;
        }
        //public override double Area()
        //{
        //    return (3.14) * Math.Pow(Radius, 2);
        //}
    }

    


}
