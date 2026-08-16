using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Creature
    {
        public int Age;
        protected int Higth;
        private int Weigth;

        //Constructor Chain
        public Creature() : this(7)
        {
            
        }
        public Creature(int weigth) : this(weigth, 10)
        {

        }
        public Creature(int weigth , int higth )
        {
            Weigth = weigth;
            Age = 1;
            Higth = higth;
        }
        public virtual void Move()
        {
            Console.WriteLine("Creature is moving");
        } 
        public virtual void Eat()
        {
            Console.WriteLine("Creature is eating");
        } 
        public void Die()
        {
            Console.WriteLine("Creature is dies");
        }

        public new void Test()
        {

        }
    }
}
