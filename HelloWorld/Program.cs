
namespace Program
{
    public class Program
    {
        // public delegate int TestDeletegate(int firstNumber, int secondNumber);

        public static void Main(string[] args)
        {

            displayNumber(Add, 5, 10);
            displayNumber2(Subtract, 5, 10);
            displayNumber(Multiply, 5, 10);
            displayNumber2((firstNumber, secondNumber) => (secondNumber/firstNumber) ,5 , 10);

            Action<int> someAction = display2;
            someAction.Invoke(5);

            Predicate<DateTime> checkDay = checkIfItIsFriday;
            System.Console.WriteLine($"{checkDay.Invoke(DateTime.Now)}"); 
            // var someDelegate = new TestDeletegate(Add);
            // var answer = someDelegate.Invoke(10,5);

            //System.Console.WriteLine(answer);
        }

        private static bool checkIfItIsFriday (DateTime dateTime){
            if (dateTime.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            } 

            return false;
            //return dateTime.DayOfWeek == 5 ? true : false;
        }


        public static void display1(int answer)
        {
            System.Console.WriteLine($"the answer is {answer}");
        }

        public static void display2(int answer)
        {
            System.Console.WriteLine($"the answer is {answer}. This is function 2");
        }

        public static void displayNumber(Func<int, int, int> someFunction, int a, int b)
        {
            Console.WriteLine($"This is Function 1. The result of operations {a} and {b} is {someFunction(a, b)}");
        }

        public static void displayNumber2(Func<int, int, int> someFunction, int a, int b)
        {
            Console.WriteLine($"This is Function 2. The result of operations {a} and {b} is {someFunction(a, b)}");
        }


        private static int Add(int a, int b) => a + b;
        private static int Subtract(int a, int b) => a - b;
        private static int Multiply(int a, int b) => a * b;

    }
}
