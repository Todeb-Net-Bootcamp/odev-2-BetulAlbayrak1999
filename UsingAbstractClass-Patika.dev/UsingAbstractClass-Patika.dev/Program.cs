using EntityLaye.Concrete;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;

namespace UsingAbstractClass_Patika.dev
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object from each class

            Console.WriteLine("Hello World!");

            Animal cat = new Cat(1, "cat1", 2, "null");
            cat.WhatIsMyType();

            Animal dog = new Dog(1, "dog1", 1, "null");
            dog.WhatIsMyType();
        }
    }
}
