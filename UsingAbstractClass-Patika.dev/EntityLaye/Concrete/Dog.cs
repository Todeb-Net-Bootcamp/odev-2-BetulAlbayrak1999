using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //this class is inheriting from Animal class
    public class Dog: Animal
    {
        public Dog(int Id, string Name, int Age, string Type) : base(Id, Name, Age, Type)
        {
        }

        public string SeriesOf { get; set; }
        public override void WhatIsMyType()
        {
            Type = "dog";
            Console.WriteLine("this function is overrided, and my type became: "+ Type);
        }
    }
}
