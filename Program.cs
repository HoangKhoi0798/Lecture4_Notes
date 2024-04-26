namespace Lecture4_Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hoang Khoi Gia Nguyen

            


            // Questions
            // 1.What are the two primary floating - point types in C#?
            // They are "float" and "double

            // 2.What is the difference between float and double in C#?
            // Double has higher range, precision and size

            // 3.Why is it generally recommended to use double instead of float for floating - point arithmetic ?
            // It is a good middle ground for precision and size, and do not requires explicit declaration.

            // 4.How does C# represent floating-point numbers internally?
            // Real numbers from 6-9 digits

            // 5.What are some common issues or considerations when performing arithmetic operations with floating - point numbers in C#?
            // Inaccurate result due to data loss
        }

        public static void FloatDeclarationUsage()
        {
            Console.Write("Enter temperature:");
            

            float userCelsius = 0;
            bool isValid = false;

            while (!isValid)
            {
                string userInput = Console.ReadLine();

                isValid = float.TryParse(userInput, out userCelsius);
                if (float.TryParse(userInput, out userCelsius))
                       {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid number: ");
                }
            }
            float userFarenheit = userCelsius * 9 / 5 + 32;
            Console.WriteLine($"Celsius: {userCelsius}");
            Console.WriteLine($"Farenheit: {userFarenheit}");
        }

        public static void ExImCasting()
        {
            int intNum = 5;
            double doubNum = 7.1198;

            double implicitCasting = intNum;
            int explicitCasting = (int)7.1198;
            Console.WriteLine($"Integer Number: {intNum},Double Number: {doubNum}");
            
            Console.WriteLine($"Impicit casted int number : {implicitCasting}, Explicit casted double number : {explicitCasting}");

            Console.WriteLine("The double is displayed like an integer when explicit casting is used to allow data loss."); 
        }

        public static void ParseStringNum()
        {
            Console.Write("Enter first integer number: ");


            int userInteger1 = 0;
            bool isValid1 = false;

            while (!isValid1)
            {
                string userInput1 = Console.ReadLine();

                isValid1 = int.TryParse(userInput1, out userInteger1);
                if (int.TryParse(userInput1, out userInteger1))
                {
                    isValid1 = true;
                }
                else
                {
                    Console.Write("Error. Enter a valid number: ");
                }
            }

            Console.Write("Enter second integer number: ");

            int userInteger2 = 0;
            bool isValid2 = false;

            while (!isValid2)
            {
                string userInput2 = Console.ReadLine();
                isValid2 = int.TryParse(userInput2, out userInteger2);
                if (int.TryParse(userInput2, out userInteger2))
                {
                    isValid2 = true;
                }
                else
                {
                    Console.Write("Error. Enter a valid number: ");
                }
            }
            int intSum = userInteger1 + userInteger2;
            Console.WriteLine($"{userInteger1} + {userInteger2} = {intSum}");
          
        }

        public static void IntDoubCircleMath()
        {
            Console.Write("Enter radius: ");
            string userInput = Console.ReadLine();

            double userRadius = double.Parse(userInput);

            int intRadius = (int)userRadius;
            

            double intArea = Math.PI * Math.Pow(intRadius, 2);
            double doubArea = Math.PI * Math.Pow(userRadius, 2);

            Console.WriteLine($"Integer Operation: {intArea}, Double Operation: {doubArea}");
            Console.WriteLine();

            Console.WriteLine("When casting to integer, the loss of decimal create a different result");

        }

        public static void RoundingNumbers()
        {

            Console.Write("Enter floating-point number: ");


            float userNum = 0;
            bool isValid = false;

            while (!isValid)
            {
                string userInput = Console.ReadLine();

                isValid = float.TryParse(userInput, out userNum);
                if (float.TryParse(userInput, out userNum))
                {
                    isValid = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }
            }
            double userRound1 = Math.Round(userNum);
            double userRound2 = Math.Round(userNum, 2);
            Console.WriteLine($"Rounded Whole Number: {userRound1}, Rounded 2 Decimals: {userRound2}");
            Console.WriteLine();
            Console.WriteLine("The result changes depending on the value of decimals inputted");
        }
        public static void TryCatchErrorHandle()
        {
            Console.Write("Enter decimal number: ");

            bool isDecimal = false;
            decimal userDecimal = 0;
            try 
            {
                string userInput = Console.ReadLine();
                userDecimal = decimal.Parse(userInput);
                isDecimal = decimal.TryParse(userInput, out userDecimal );
                Console.WriteLine($"Currency: {userDecimal.ToString("c")} ");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid number");
                Console.WriteLine(ex.StackTrace);
            }
            
        }
    }
}
