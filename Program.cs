namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome Class & Objects examples");
            Console.WriteLine("Choose options in below programs:");
            Console.WriteLine("\n1.AdditionFirst50Num\n2.EvenNumbers\n3.ConcatenateStrings\n4.Variables\n5.TypesofMethods\n6.Inheritance");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Add50Num1 add50Num1 = new Add50Num1();
                    add50Num1.Addition50Num();
                    break;
                    case 2:
                    EvenNumbers2 evenNumbers2 = new EvenNumbers2();
                    evenNumbers2.EvenNum();
                    break;
                case 3:
                    ConcatenateStrings3 concatenate = new ConcatenateStrings3();
                    concatenate.Concatenate();
                    break;
                case 4:
                    variables variables = new variables();
                    variables.var();

                    break;
                case 5:
                    Methods methods = new Methods();
                    methods.InstanceMethod();
                    
                    int result = methods.MethodWithReturnValue(10, 20);
                    Console.WriteLine("Sum: " + result);

                    break;
                case 6:
                    Address address = new Address();
                    address.Village();
                    Console.WriteLine(address.village + " " + address.city);
                    break;
            }
        }
    }
}