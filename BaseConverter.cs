using System;
namespace BaseConverter
{
   class Program
   {
       public static void Main()
       {
	  User();
       }
	   public static void User()
	   {
	    Console.WriteLine("The Bases Coverter Machine");
		string Options = @"
    
		                   press 1: To Convert form base 10 to the other Base
						           press 2: To Convert from other Base To Base 10;
						           press 3 : To convert from one base to the other base";
        int option = int.Parse(Console.ReadLine());
		    if(option == 1)
			{
         Console.WriteLine(option);
			   Console.WriteLine("input decimal number");
			   int decimalNum = int.Parse(Console.ReadLine());
			   Console.WriteLine("converted to base?");
			   int baseNum = int.Parse(Console.ReadLine());
			   DecimalToBase(decimalNum, baseNum);
			}
		    else if(option == 2)
			{
			   Console.WriteLine("input  number");
			   string inputNum = Console.ReadLine();
			   Console.WriteLine("number is in base?");
			   int theBase = int.Parse(Console.ReadLine());
			   BaseToDecimal(inputNum, theBase);
			}
		    else if(option == 3)
			{
			   Console.WriteLine("input number to be converted");
			   string number = Console.ReadLine();
			   Console.WriteLine("number is in base?");
			   int theNumberBase = int.Parse(Console.ReadLine());
			   Console.WriteLine("To waht base?");
			   int theNewBase = int.Parse(Console.ReadLine());
			  BaseToBase(number, theNumberBase, theNewBase);
			}
		
	   }

       public static string BaseToBase(string Number, int TheNumbersBase, int TheNewBase)
       {
           int decimalNumber = BaseToDecimal(Number, TheNumbersBase);
           return DecimalToBase(decimalNumber, TheNewBase);


       }

       public static string DecimalToBase(int decimalInput, int baseNumber)
       {
           string hexMap = "0123456789ABCDEF";
           string result = "";
           if (decimalInput > 0)
           {
               int newNumber = decimalInput % baseNumber;
               decimalInput = decimalInput / baseNumber;
               char newNumberString = hexMap[newNumber];
               result = newNumberString + result;
           }
               return result;          

       }


       public static int BaseToDecimal(string inputNum, int theBase)
       {
           string newInput = inputNum.ToUpper();
           string hexMap = "0123456789ABCDEF";
           int decimalValue = 0;
           int power = inputNum.Length;

           for (int i = 0; i < inputNum.Length; i++)
           {
               string eachValue = newInput.Substring(i, 1);
               int Value = hexMap.IndexOf(eachValue);
               decimalValue += Value * (int)Math.Pow(theBase, power - 1);
               power--;
           }
           return decimalValue;
       }

   }

}
