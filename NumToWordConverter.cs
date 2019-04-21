using System;

public class NumberToWord {

	// String for digit places
	  static String[] digit = { "", "one", "two", "three", "four", "five",
			"six", "seven", "eight", "nine", "ten", "eleven", "twelve",
			"thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
			"eighteen", "nineteen" };

	// String for tens places
	   static String[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty",
			"sixty", "seventy", "eighty", "ninety" }; 
	  
	   public static void Trillion(long num)
	   {
	      long temp = num;
		   long firstDigit = temp/1000000000000;
		   long firstDigitLen = firstDigit.ToString().Length;
		   long rem = temp % 1000000000000;
		    if(firstDigitLen ==1  || firstDigitLen ==2)
		  {
		      if(rem ==0)
			  {
			  twodigit(firstDigit); Console.Write(" trillion");
			  }
			  else if (rem < 100)
			  {
			   twodigit(firstDigit); Console.Write(" trillion and "); twodigit(rem);
			  }
			  else if(rem >= 100 && rem < 1000) 
			  {
			  twodigit(firstDigit); Console.Write(" trillion "); threeDigitToWord(rem); 
			  }
			 else if(rem>= 1000 && rem < 1000000)
			 {
			  twodigit(firstDigit); Console.Write(" trillion "); FourDigitToWord(rem); 
			 }
			 else if(rem>= 1000000 && rem < 1000000000 )
			 {
			  twodigit(firstDigit); Console.Write(" trillion "); Million(rem);
				 
			 }
			 else if(rem >= 1000000000 && rem < 1000000000000 )
			 {
			   twodigit(firstDigit); Console.Write(" trillion "); Billion(rem);
			 }
			
		  }
		   //gfjhjvhsf;ik
		   
		     if(firstDigitLen == 3)
		  {
		      if(rem ==0)
			  {
			   threeDigitToWord(firstDigit); Console.Write(" trillion ");
			  }
			  else if (rem < 100)
			  {
			    threeDigitToWord(firstDigit); Console.Write(" trillion and "); twodigit(rem);
			  }
			  else if(rem >= 100 && rem < 1000) 
			  {
			   threeDigitToWord(firstDigit); Console.Write(" trillion "); threeDigitToWord(rem); 
			  }
			 else if(rem>= 1000 && rem < 1000000)
			 {
			   threeDigitToWord(firstDigit); Console.Write(" trillion "); FourDigitToWord(rem); 
			 }
			 else if(rem>= 1000000 && rem < 1000000000 )
			 {
			  threeDigitToWord(firstDigit); Console.Write(" trillion "); Million(rem);
				 
			 }
			 else if(rem >= 1000000000 && rem < 1000000000000 )
			 {
			   threeDigitToWord(firstDigit); Console.Write(" trillion "); Billion(rem);
			 }
			
		  }
	  }
	    
	   public static void Billion(long num)
	   {
		   long temp = num;
		   long firstDigit = temp/1000000000;
		   long firstDigitLen = firstDigit.ToString().Length;
		   long rem = temp % 1000000000;
		    if(firstDigitLen ==1  || firstDigitLen ==2)
		  {
		      if(rem ==0)
			  {
			  twodigit(firstDigit); Console.Write(" billion");
			  }
			  else if (rem < 100)
			  {
			   twodigit(firstDigit); Console.Write(" billion and "); twodigit(rem);
			  }
			  else if(rem >= 100 && rem < 1000) 
			  {
			  twodigit(firstDigit); Console.Write(" billion "); threeDigitToWord(rem); 
			  }
			 else if(rem>= 1000 && rem < 1000000)
			 {
			  twodigit(firstDigit); Console.Write(" billion "); FourDigitToWord(rem); 
			 }
			 else if(rem>= 1000000 && rem < 1000000000 )
			 {
			  twodigit(firstDigit); Console.Write(" billion "); Million(rem);
				 
			 }
			
		  }
		   //gfjhjvhsf;ik
		   
		     if(firstDigitLen == 3)
		  {
		      if(rem ==0)
			  {
			   threeDigitToWord(firstDigit); Console.Write(" billion");
			  }
			  else if (rem < 100)
			  {
			    threeDigitToWord(firstDigit); Console.Write(" billion and "); twodigit(rem);
			  }
			  else if(rem >= 100 && rem < 1000) 
			  {
			   threeDigitToWord(firstDigit); Console.Write(" billion "); threeDigitToWord(rem); 
			  }
			 else if(rem>= 1000 && rem < 1000000)
			 {
			   threeDigitToWord(firstDigit); Console.Write(" billion "); FourDigitToWord(rem); 
			 }
			 else if(rem>= 1000000 && rem < 1000000000 )
			 {
			  threeDigitToWord(firstDigit); Console.Write(" billion "); Million(rem);
				 
			 }
			
		  }
		   
		   
		   
	   }
	   public static void Million(long num)
	   {
	     long temp = num;
		 long firstDigit = temp/1000000;
		 long firstDigitLen = firstDigit.ToString().Length;
		  long rem = temp% 1000000;
		  if(firstDigitLen ==1  || firstDigitLen ==2)
		  {
		      if(rem ==0)
			  {
			  twodigit(firstDigit); Console.Write(" million");
			  }
			  else if (rem < 100)
			  {
			   twodigit(firstDigit); Console.Write(" million and "); twodigit(rem);
			  }
			  else if(rem < 1000 )
			  {
			  twodigit(firstDigit); Console.Write(" million "); threeDigitToWord(rem); 
			  }
			 else if(rem < 1000000)
			 {
			  twodigit(firstDigit); Console.Write(" million "); FourDigitToWord(rem); 
			 }
			
		  }
		   //
		   
		   if(firstDigitLen ==3)
		  {
		      if(rem ==0)
			  {
			   threeDigitToWord(firstDigit); Console.Write(" million");
			  }
			  else if (rem < 100)
			  {
			   threeDigitToWord(firstDigit);  Console.Write(" million and "); twodigit(rem);
			  }
			  else if(rem < 1000 )
			  {
			  threeDigitToWord(firstDigit);  Console.Write(" million "); threeDigitToWord(rem); 
			  }
			 else if(rem < 1000000)
			 {
			  threeDigitToWord(firstDigit);  Console.Write(" million "); FourDigitToWord(rem); 
			 }
			
		  }
	   } 

	   public static void FourDigitToWord(long num)
		{
			long temp = num;
			long firstDigit = temp/1000;
			long firstDigitLen = firstDigit.ToString().Length;
			long rem = temp%1000;
			if(firstDigitLen ==1  || firstDigitLen ==2)
			{
			  if(rem ==0)
			  {
			  twodigit(firstDigit); Console.Write(" thousand");
			  }
			  else if (rem < 100)
			  {
			   twodigit(firstDigit); Console.Write(" thousand and "); twodigit(rem);
			  }
			  else if(rem >= 100 && rem < 1000 )
			  {
			  twodigit(firstDigit); Console.Write(" thousand  "); threeDigitToWord(rem); 
			  }
			 else if(rem > 1000)
			 {
				   twodigit(firstDigit); Console.Write(" thousand  "); FourDigitToWord(rem);
			 }
		   }
			
			if(firstDigitLen ==3)
			  {
			  if(rem ==0)
			  {
			   threeDigitToWord(firstDigit);  Console.Write(" thousand");
			  }
			  else if (rem < 100)
			  {
			   threeDigitToWord(firstDigit); Console.Write(" thousand and "); twodigit(rem);
			  }
			  else if(rem >= 100 && rem < 1000 )
			  {
			   threeDigitToWord(firstDigit); Console.Write(" thousand  "); threeDigitToWord(rem); 
			  }
			
		   }
		}
		public static void threeDigitToWord(long num) 
		{
		long temp = num;
		long firstDigit = temp / 100;
		if (temp % 100 == 0)
			Console.Write(digit[firstDigit] + " hundred ");
		else
			Console.Write(digit[firstDigit] + " hundred and ");
		long lastTwoDigit = num % 100;
		twodigit(lastTwoDigit);
	  }

	// To convert two digit no to words
	public static void twodigit(long num)
	{
		if (num < 20) {
			Console.Write(digit[num]);
		} else {
			long firstDigit, secondDigit;
			secondDigit = num % 10;
			firstDigit = num / 10;
			Console.Write(tens[firstDigit] + " " + digit[secondDigit]);
		}
	} 
	
     public static void Process()
	 {    		
		 long numS;
	      Console.WriteLine("enter a number to be converted to word");
		  bool success = long.TryParse(Console.ReadLine(), out numS);
	      if(success)
		  {
		       long num = numS.ToString().Length;
			   if(num == 1 || num == 2)
			   {
			   twodigit(numS); 
			   }
			   else if (num == 3)
			   {
			   threeDigitToWord(numS);
			   }
			    else if(num == 4 || num == 5 || num == 6)
			   {
			    FourDigitToWord(numS);
			   } 
			   else if(num == 7 || num == 8 || num == 9)
			   {
			    Million(numS);
			   }
			   else if(num == 10 || num == 11 || num == 12)
			   {
			    Billion(numS);
			   }
			   else if(num == 13 || num == 14 || num == 15)
			   {
			     Trillion(numS);
			   }
			  
            }
		   Console.ReadLine();
	   } 
	 public static void Main()
	 {
	  Process();
	 }
      
}	
	
