namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Inheritnce & Polymarphism
            /* Creature c1 = new Creature();
                Creature c2 = new Creature(100);*/

            //Human h = new Human();
            //h.Move();
            // can see all attributes in human and creature that inherite it

            //Creature c3 = new Human();
            //c3.Test();
            //c3.Move();
            // can see only attributes that human inherite it from creature

            //Employee e1 = new Employee();
            //Human h1 = new Employee();
            //Creature c4 = new Employee();

            //e1.Eat(); 
            //c4.Eat(); 
            //h1.Eat(); 
            #endregion

            Human h1 = new Human();
            Human h2 = new Human();

            h1.Age = h2.Age = 10;

            if (h1.Equals(100))
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());

            Console.WriteLine(h1.GetHashCode());
            Console.WriteLine(h2.GetHashCode());


            Human h3 = h1.Clone();
        }
    }
}
