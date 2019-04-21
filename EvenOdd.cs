using System;
					
public class EvenOrODD
{  
	public static bool EvenOdd(int num)
	{
	   return ((num % 2) == 0)? true : false;
	}
    public static void User()
	{  
		int numS;
	   Console.WriteLine("This app help you know wheather your number is even or odd");
		incorrect:
	   Console.WriteLine("enter a number");
	   bool success = int.TryParse(Console.ReadLine(), out numS);
		if(success){
		    bool answer = EvenOdd(numS);
			if(answer == true)
			{
			Console.WriteLine("an even number");
			}
			else 
			{
			Console.WriteLine("a odd number");
			}
		}
		else{
		     Console.WriteLine("please input a correct number");
		      goto incorrect;
		}
		
	}
	public static void Main()
	{
	  User();
	  
	}
	
}
