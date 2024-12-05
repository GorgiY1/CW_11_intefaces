using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using static System.Math;

namespace CW_11_inteface
{
    /* static class StaticClass
     {
         public static double Price { get; set; }

         static StaticClass()
         {

         }
     }

     //class MyClass: StaticClass {}*/

    interface IFly
    {
        void Fly();
    }
    
    interface ISwim
    {
        void Swim();
    }

    interface IRun
    {
        void Run();
    }
    abstract class Bird
    {
        protected string name;

        public bool IsEggs { get; set; }

        //public abstract void Fly();
        
    }

    class Duck:Bird,IFly,ISwim
    {
        public Duck()
        {
            name = "Duck";
        }

        public void Fly()
        {
            Console.WriteLine(name);
        }

        public void Swim()
        {
            Console.WriteLine($"{name} swim");
        }
        //public override void Fly()
        //{
        //    Console.WriteLine(name);
        //}

    }

    class Penguin : Bird,ISwim, IRun
    {
        public Penguin()
        {
            name = "Penguin";
        }
        public void Fly()
        {
           //
        }
        public void Run()
        {
            //
        }
        public void Swim()
        {
            //
        }
    }

    class Ostrich : Bird
    {
        public Ostrich()
        {
            name = "Ostrich";
        }
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }

    abstract class Insect
    {
        protected string name;
    }

    class Butterfy : Insect,IFly
    {
        public Butterfy()
        {
            name = "Butterfy";
        }

        public void Fly()
        {
            Console.WriteLine(name);
        }
    }

    class Plane : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Plane");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*StaticClass.Price = 4567;
            Console.WriteLine(StaticClass.Price);
            Console.WriteLine(PI);*/

            ISwim swim = new Penguin();

            IFly[] flies = { new Duck(), new Butterfy(), new Plane()};

            foreach (IFly item in flies)
            {
                item.Fly();
            }

            Bird[] birds = { new Penguin(), new Ostrich(), new Duck() };

            Console.WriteLine();
            foreach (Bird item in birds)
            {
                if (item is IFly fly)
                {
                    fly.Fly();
                }
            }

            IFly duck = new Duck();

            ISwim swim1 = duck as ISwim;
            swim1.Swim();

            Console.ReadKey();
        }
    }
}
