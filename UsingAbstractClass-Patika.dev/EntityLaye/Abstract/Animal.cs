using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public abstract class Animal
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public int Age { get; set; } 
        public string Type { get; set; } 

        public Animal(int Id, string Name, int Age, string Type) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Type = Type;

        }
        public virtual void WhatIsMyType() 
        {
            Console.WriteLine("you need to override this function, and assign a value to the type property!");
        }
    }
}
