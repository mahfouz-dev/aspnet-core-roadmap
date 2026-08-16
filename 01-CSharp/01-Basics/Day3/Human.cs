using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Human : Creature 
    {
        public SecureString Name;
        public override void Move()
        {
           // base.Move(); // call function move in parent class (creature)
            Console.WriteLine("Human is moving");
        }
        public void Think()

        {
            Console.WriteLine("Human Are Thinking");
        }

        public virtual void Test()
        {

        }
        public new virtual void Eat()
        {
            Console.WriteLine("Human is eating");
        }
        public override bool Equals(object obj)
        {
            //Human h = obj as Human;

            //if (h != null)
            //    return this.Age == h.Age;
            //return false;

            //if (obj is Human)
            //{
            //    Human h = obj as Human;
            //    return this.Age == h.Age;
            //}
            //return false;

            if (obj is Human h)
            {
                return this.Age == h.Age;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Human With Age = {Age}";
        }

        public Human Clone()
        {
            return (Human)this.MemberwiseClone();
        }

        
    }
}
