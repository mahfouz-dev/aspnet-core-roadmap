using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace Day2
{
    #region Enum
    enum Gender
    {
        Male = 0,
        Female = 1,
    }
    //[Flags]
    //enum Weather
    //{
    //    Normal = 1,
    //    Sunny = 2,
    //    Windy = 4,
    //    Rainy = 8
    //} 
    #endregion
    internal class Program
    {
        #region Func Of Ref Type
        /*
        static void Test(int a)
        {
            a = 10;
        } 
        static void Test(person obj)
        {
            obj.id = 1; 
        }
        */
        #endregion
        static void Main(string[] args)
        {
            #region Ref Type
            /*
               person p1 = new person();
               p1.id = 10;

               //person p2 = null;
               //p2.id = 20; // error => NullReferenceException

               person p3 = new person();
               p3 = p1; // legal syntax

               //funcion test
               int x = 10;
               Test(x);
               Test(p1);
               */
            #endregion

            #region Enum
            //enum
            //Gender g = Gender.Male;    
            //Gender g2 = (Gender)1;
            //Console.WriteLine(g);
            //Console.WriteLine(g2);
            //Console.WriteLine((int)g2);
            //Console.WriteLine("==================");

            //Weather weatheToday = Weather.Rainy | Weather.Windy;
            //Console.WriteLine(weatheToday);

            //if(weatheToday == (Weather.Rainy | Weather.Windy)) // true
            // if ((weatheToday & Weather.Rainy) == Weather.Rainy) ;// true

            //"==================

            // gender in class person

            //person p = new person();
            //p.Type = Gender.Male;

            //if (p.Type == Gender.Male)
            //    Console.WriteLine("Male");
            //else
            //    Console.WriteLine("Feale"); 
            #endregion

            #region Struct
            //Complex c1;
            //Complex c2 = new Complex();
            //c1.Real = 10;
            //c1.Img = 20;
            //Console.WriteLine($"{c1.Real} \t {c1.Img}");

            //Console.WriteLine("======================");

            //Complex c3 = new Complex(3 , 5); // initialized constructor
            //Console.WriteLine($"{c2.Real} , {c2.Img}");

            //Console.WriteLine("======================");

            ////Overload Operator +

            ////c1 = c2 + c3; // error , you must overload first
            //c1 = c2 + c3;

            ////Implicit Operator 

            //Complex c4 = 100;
            //Console.WriteLine("======================");
            ////Overload Operator ==

            //if (c1 == c3) ;

            //Console.WriteLine("======================");

            ////Overload Operator ++
            //Complex c5 = c1++;
            //Complex c6 = ++c1; 
            #endregion

            #region Class
            //person p1 = new person(10);
            //person p2 = new person(10);
            //person p3 = p1;
            //Console.WriteLine(p1.id);
            //if (p1 == p2)
            //    Console.WriteLine("Equal");
            //else Console.WriteLine("Not Equal"); 

            //if (p3 == p1)
            //    Console.WriteLine("Equal");
            //else Console.WriteLine("Not Equal");  
            #endregion
        }
    }
}
