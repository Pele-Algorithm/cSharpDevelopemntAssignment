using System;
namespace ClassAss
{
    public class NumberToWord
    {

        // String for digit places
         static String[] digit = { "", "one", "two", "three", "four", "five",
            "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
            "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
            "eighteen", "nineteen" };

        // String for tens places
        static String[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty",
            "sixty", "seventy", "eighty", "ninety" };

        public static string Result { get; set; } = "";
       

        public static string Trillion(long num)
        {
            long temp = num;
            long firstDigit = temp / 1000000000000;
            long firstDigitLen = firstDigit.ToString().Length;
            long rem = temp % 1000000000000;
            if (firstDigitLen == 1 || firstDigitLen == 2)
            {
                if (rem == 0)
                {
                    Result = $"{Twodigit(firstDigit)}   trillion";
                }
                else if (rem < 100)
                {
                 Result =$"{Twodigit(firstDigit)}  trillion and  {Twodigit(rem)}";
                }
                else if (rem >= 100 && rem < 1000)
                {
                    Result = $"{Twodigit(firstDigit)}  trillion {ThreeDigitToWord(rem)}";
                }
                else if (rem >= 1000 && rem < 1000000)
                {
                  Result = $" {Twodigit(firstDigit)}   trillion  {FourDigitToWord(rem)}";
                }
                else if (rem >= 1000000 && rem < 1000000000)
                {
                    Result = $"{Twodigit(firstDigit)}  trillion  {Million(rem)}";

                }
                else if (rem >= 1000000000 && rem < 1000000000000)
                {
                    Result = $" {Twodigit(firstDigit)}  trillion  {Billion(rem)}";
                }

            }
            //gfjhjvhsf;ik

            if (firstDigitLen == 3)
            {
                if (rem == 0)
                {
                  Result =$"{ThreeDigitToWord(firstDigit)}  trillion ";
                }
                else if (rem < 100)
                {
                  Result = $"{ThreeDigitToWord(firstDigit)}  trillion and {Twodigit(rem)}";
                }
                else if (rem >= 100 && rem < 1000)
                {
                    Result = $" {ThreeDigitToWord(firstDigit)}  trillion {ThreeDigitToWord(rem)}";
                }
                else if (rem >= 1000 && rem < 1000000)
                {
                    Result = $"{ThreeDigitToWord(firstDigit)}  trillion  {FourDigitToWord(rem)}";
                }
                else if (rem >= 1000000 && rem < 1000000000)
                {
                    Result = $"{ThreeDigitToWord(firstDigit)}   trillion {Million(rem)}";

                }
                else if (rem >= 1000000000 && rem < 1000000000000)
                {
                 Result =$"{ThreeDigitToWord(firstDigit)}  trillion  {Billion(rem)}";
                }

            }
            return Result;
        }

        public static string Billion(long num)
        {
            long temp = num;
            long firstDigit = temp / 1000000000;
            long firstDigitLen = firstDigit.ToString().Length;
            long rem = temp % 1000000000;
            if (firstDigitLen == 1 || firstDigitLen == 2)
            {
                if (rem == 0)
                {
                 Result = $"{Twodigit(firstDigit)}  billion";
                }
                else if (rem < 100)
                {
                  Result =$"{Twodigit(firstDigit)}  billion and {Twodigit(rem)}";
                }
                else if (rem >= 100 && rem < 1000)
                {
                   Result = $"{Twodigit(firstDigit)}  billion {ThreeDigitToWord(rem)}";
                }
                else if (rem >= 1000 && rem < 1000000)
                {
                 Result = $"{Twodigit(firstDigit)} billion {FourDigitToWord(rem)}";
                }
                else if (rem >= 1000000 && rem < 1000000000)
                {
                 Result = $"{Twodigit(firstDigit)}  billion   {Million(rem)}";

                }

            }

            if (firstDigitLen == 3)
            {
                if (rem == 0)
                {
                   Result = $"{ThreeDigitToWord(firstDigit)}   billion";
                }
                else if (rem < 100)
                {
                    Result =$"{ThreeDigitToWord(firstDigit)}  billion and {Twodigit(rem)}";
                }
                else if (rem >= 100 && rem < 1000)
                {
                 Result = $"{ThreeDigitToWord(firstDigit)} billion {ThreeDigitToWord(rem)}";
                }
                else if (rem >= 1000 && rem < 1000000)
                {
                 Result = $"{ThreeDigitToWord(firstDigit)}  billion  {FourDigitToWord(rem)}";
                }
                else if (rem >= 1000000 && rem < 1000000000)
                {
                  Result = $"{ThreeDigitToWord(firstDigit)}  billion   {Million(rem)}";

                }
                
            }

            return Result;

        }
        public static string Million(long num)
        {
            long temp = num;
            long firstDigit = temp / 1000000;
            long firstDigitLen = firstDigit.ToString().Length;
            long rem = temp % 1000000;
            if (firstDigitLen == 1 || firstDigitLen == 2)
            {
                if (rem == 0)
                {
                  Result= $"{Twodigit(firstDigit)}  million";
                }
                else if (rem < 100)
                {
                   Result =$"{Twodigit(firstDigit)}  million and {Twodigit(rem)}";
                }
                else if (rem < 1000)
                {
                    Result = $" {Twodigit(firstDigit)} million {ThreeDigitToWord(rem)}";
                }
                else if (rem < 1000000)
                {
                    Result = $"{Twodigit(firstDigit)}  million {FourDigitToWord(rem)}";
                }

            }
            //

            if (firstDigitLen == 3)
            {
                if (rem == 0)
                {
                  Result = $"{ThreeDigitToWord(firstDigit)}  million";
                }
                else if (rem < 100)
                {
                 Result = $"{ThreeDigitToWord(firstDigit)}  million and {Twodigit(rem)}";
                }
                else if (rem < 1000)
                {
                Result =  $"{ThreeDigitToWord(firstDigit)}  million  {ThreeDigitToWord(rem)}";
                }
                else if (rem < 1000000)
                {
                 Result = $"{ ThreeDigitToWord(firstDigit)}  million  {FourDigitToWord(rem)}";
                }

            }
            return Result;
        }

        public static string FourDigitToWord(long num)
        {
            var temp = num;
            long firstDigit = temp / 1000;
            long firstDigitLen = firstDigit.ToString().Length;
            long rem = temp % 1000;
            if (firstDigitLen == 1 || firstDigitLen == 2)
            {
                if (rem == 0)
                {
                  Result = $"{Twodigit(firstDigit)}   thousand";
                }
                else if (rem < 100)
                {
                   Result = $"{Twodigit(firstDigit)}  thousand and  {Twodigit(rem)}";
                }
                else if (rem >= 100 && rem < 1000)
                {
                  Result = $"{Twodigit(firstDigit)}  thousand  {ThreeDigitToWord(rem)}";
                }
                else if (rem > 1000)
                {
                   Result =  $"{Twodigit(firstDigit)}  thousand  {FourDigitToWord(rem)}";
                }
            }

            if (firstDigitLen == 3)
            {
                if (rem == 0)
                {
                  Result =  $"{ThreeDigitToWord(firstDigit)}  thousand";
                }
                else if (rem < 100)
                {
                   Result =  $"{ThreeDigitToWord(firstDigit)}  thousand and   {Twodigit(rem)}";
                }
                else if (rem >= 100 && rem < 1000)
                {
                    Result = $"{ThreeDigitToWord(firstDigit)}   thousand    {ThreeDigitToWord(rem)}";
                }
               
            }
            return Result;
        }
        public static string ThreeDigitToWord(long num)
        {
            long temp = num;
            long firstDigit = temp / 100;
            if (temp % 100 == 0)
            {
                Result = digit[firstDigit] + " hundred ";
                return Result;
            }
            else
            {
                string res1 = digit[firstDigit] + " hundred and ";
                long lastTwoDigit = num % 100;
                string res2 = Twodigit(lastTwoDigit);
                Result = res1 + " "+ res2;
                return Result;
            }
        }

        // To convert two digit no to words
        public static string Twodigit(long num)
        {
            if (num < 20)
            {
                Result = digit[num];
                return Result;
            }
            else
            {
                long firstDigit, secondDigit;
                secondDigit = num % 10;
                firstDigit = num / 10;
                Result = tens[firstDigit] + " " + digit[secondDigit];
                return Result;
            }
        }

        public static void Process()
        {
            Console.WriteLine("enter a number to be converted to word");
            bool success = long.TryParse(Console.ReadLine(), out long numS);
            string str = "";
            if (success)
            {
                long num = numS.ToString().Length;
                if (num == 1 || num == 2)
                {
                 str = Twodigit(numS);
                    Console.WriteLine(str);
                }
                else if (num == 3)
                {
                    str = ThreeDigitToWord(numS);
                    Console.WriteLine(str);

                }
                else if (num == 4 || num == 5 || num == 6)
                {
                   str =  FourDigitToWord(numS);
                    Console.WriteLine(str);

                }
                else if (num == 7 || num == 8 || num == 9)
                {
                   str = Million(numS);
                    Console.WriteLine(str);

                }
                else if (num == 10 || num == 11 || num == 12)
                {
                  str =  Billion(numS);
                   Console.WriteLine(str);

                }
                else if (num == 13 || num == 14 || num == 15)
                {
                  str =  Trillion(numS);
                    Console.WriteLine(str);

                }

            }
            Console.ReadLine();
        }
        public static void Main()
        {
            Process();
        }

    }
}
