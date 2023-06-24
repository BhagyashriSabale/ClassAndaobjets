namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome Class & Objects examples");
            Console.WriteLine("Choose options in below programs:");
            Console.WriteLine("\n1.AdditionFirst50Num");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Add50Num1 add50Num1 = new Add50Num1();
                    add50Num1.Addition50Num();
                    break;
            }
        }
    }
}