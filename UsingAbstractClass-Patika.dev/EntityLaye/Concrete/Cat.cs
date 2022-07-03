using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLaye.Concrete
{
    //this class is inheriting from Animal class
    public class Cat : Animal
    {
        public Cat(int Id, string Name, int Age, string Type) : base(Id, Name, Age, Type)
        {
        }

        public string SeriesOf { get; set; }
        public override void WhatIsMyType()
        {
            Type = "cat";
            Console.WriteLine("this function is overrided, and my type became: " + Type);
        }
    }
}
