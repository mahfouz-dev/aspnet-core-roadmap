namespace Day1
{
    internal class Program
    {
        static void swap(ref int num1, ref int num2)
        {
           int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        static int Divide(int num1 , int num2 , out int remn)
        {
            remn = num1 % num2;
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            int x = 10;
            float y = 20.2f;
            Console.WriteLine($"x = {x} \t y= {y}");
            Console.WriteLine("x = {0} \t y= {1}", x, y);
            Console.WriteLine("=============");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a);

            Console.WriteLine("=============");

            int b = 10, c = 20;
            swap(ref b, ref c);
            Console.WriteLine($"{b} \t {c}");

            Console.WriteLine("=============");
            int num1 = 4;
            int num2 = 2;
            int rem;
            int resutl = Divide(num1, num2 ,out rem);
            Console.WriteLine(resutl);//2
            Console.WriteLine(rem); //0
        }
    }
}
