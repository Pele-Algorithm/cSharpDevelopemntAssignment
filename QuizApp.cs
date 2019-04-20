using System;

public class QuizApp
{  
   static string name, address, age;
   string[] Question, Answer;
 
	public static void DisplayForm()
	{ 
		   string displayForm = @"Welcome to Quiz.console.com !
                                 ====================================================
                                 Here, you can read the aptitude questions and answers
                                 for your interview and entrance exams preparation.
                                 ******************************************************
                                 Happy Learning!
                                 *******************************************************
                                 input your informations to get started.
                                 =====================================================
                                 ";
            Console.WriteLine(displayForm);
            Console.WriteLine("Enter your name:");
             name = Console.ReadLine();
            Console.WriteLine("Enter your address:");
             address = Console.ReadLine();
            Console.WriteLine("Enter your age:");
             age = Console.ReadLine();	
 	}

	public static void DataProcess()
	{ 
		int numS;
	string select = @"                    
	                                             Selection your type of question:
	                                             ================================
					              Input the number preceding your selected  type of questions 
								  1: mathematics
							   // 2. General Knowlegde(coming soon)
								  ";
		Console.WriteLine(select);
	    bool success = int.TryParse(Console.ReadLine(), out numS);
	if(success)
    {	
		if(numS == 1)
	   {
	 Console.WriteLine("{0},you have selected mathematics",name);		
	 Console.WriteLine("*Begin test*");
		
	  string[] mathQuestion = new string[]{@" 
	     (1)The value of x + x(xx) when x = 2 is:
         (a) 10, (b) 16, (c) 18, (d) 36, (e) 64",
        @"
		 (2)Mr. Jones sold two pipes at $1.20 each. Based on the cost, his profit one was 20% 
		 and his loss on the other was 20%. On the sale of the pipes, he:
         (a) broke even, (b) lost 4 cents, (c) gained 4 cents, (d) lost 10 cents, (e) gained 10 cents",
		@"
		 (3)The distance light travels in one year is approximately 5,870,000,000,000 miles. 
		    The distance light travels in 100 years is:
            (a) 587 × 108 miles, (b) 587 × 1010 miles, (c) 587 × 10-10 miles, (d) 587 × 1012 miles, (e) 587 × 10-12 miles ",
		@"
		 (4)5. A man has $ 10,000 to invest. He invests $ 4000 at 5 % and $ 3500 at 4 %. 
		 In order to have a yearly income of $ 500, he must invest the remainder at:
          (a) 6 %, (b) 6.1 %, (c) 6.2 %, (d) 6.3 %, (e) 6.4 %",
		 @"
		  (5)Jones covered a distance of 50 miles on his first trip. On a later trip he traveled 300 miles while going three times as fast. 
		  His new time compared with the old time was:
          (a) three times as much, (b) twice as much, (c) the same, (d) half as much, (e) a third as much ",
		 @"
		  (6)If (0.2)x = 2 and log 2 = 0.3010, then the value of x to the nearest tenth is:
           (a) -10.0, (b) -0.5, (c) -0.4, (d) -0.2, (e) 10.0",
		 @"
		  (7)If 102y = 25, then 10-y equals:
          (a) -1/5, (b) 1/625, (c) 1/50, (d) 1/25, (e) 1/5",
		 @"
		  (8)The fraction (5x-11)/(2x2 + x - 6) was obtained by adding the two fractions A/(x + 2) and B/(2x - 3).
		  The values of A and B must be, respectively:
         (a) 5x, -11, (b) -11, 5x, (c) -1, 3, (d) 3, -1, (e) 5, -11",
		 @"
		 (9)The sum of three numbers is 98. The ratio of the first to the second is 2/3, and 
		 the ratio of the second to the third is 5/8. The second number is:
         (a) 15, (b) 20, (c) 30, (d) 32, (e) 33",
		 @"
		 (10)-*-*+*- =
		  (a) -, (b) +, (c) - or +, (d) 1, (e) 0",
				                                                    };
	  string[] mathAnswer = new string []{"a", "a", "d","e","b","c","e","d","c","a"};
		int i = -1; int score = 0;
next:		
		 ++i;  
         while(i < mathQuestion.Length)
		 {
		  back:  Console.WriteLine(mathQuestion[i]);		
			 string ans =  Console.ReadLine();
			       if(ans.ToLower() =="a" || ans.ToLower() == "b" || ans.ToLower() == "c" || ans.ToLower() == "d" || ans.ToLower() == "e")  
			       {
				            if (ans == mathAnswer[i])
				            {
				              score = score + 10;
				            }
			               else if(ans != mathAnswer[i])
				            {
				            score = score + 0;
				            }
				  }
			      else
			      {
			          Console.WriteLine("input a correct option");
				      goto back;
			     }
				           
			     Console.WriteLine("enter \"N\" to go to the next Quesion or \"P\" to go back to the previous question");
				 string next = Console.ReadLine();
				 if(next.ToUpper() == "N")
				 {
				     goto next;
				 }
				else if (next.ToUpper() == "P" )
				 {
				    if(i == 0){
						i = 0;
						score = score - 10;
					   goto back;
					}
					 else if((i > 0) && (ans == mathAnswer[i])){
					    --i; 
						 score = score - 20;
						goto back;
					 }
				 }
			  else
				 {
				  Console.WriteLine("input the correct command");
				 }
		  } 
			string end = @"   
			                    welldone!
			                ******End of quiz*****
			                processing test result.
						   ";
			Console.WriteLine(end);
			for(int j = 0; j < 5; j++){
				Console.WriteLine("loading...........");
			}
Console.WriteLine(@"
UserName: {0}
UserAge : {1}
UserAddress: {2}", name,age,address );
Console.Write("your score is : {0}%", score);
Console.ReadLine();
		
			
	  }
		}
		else Console.WriteLine("please enter a correct input");	
  }	
		
	  public static void Main()
	  {
	     DisplayForm();
	     DataProcess();
	  }
	
}

	
		
	

