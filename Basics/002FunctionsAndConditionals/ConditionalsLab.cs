using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Welcome");
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 7);
		myOperator.DoMath(30, 15);
		myOperator.Compare(4,3);
		myOperator.Compare(3,4);
		myOperator.CheckPassword("SevenOF9");
		myOperator.CheckPassword("OU812");
	}
}

public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, the first greater.");
		} else {
			Console.WriteLine("False, the second is greater.");
		}
	}
	
	public void CheckPassword (string password) {
		if(password == "OU812") {
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");	
		}
	}
}


namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      if (20 > 18) 
      if (19 < 20)
      {
        Console.WriteLine("20 is greater than 18");
        Console.WriteLine("19 is less than 20");
      }    
    }
  }
}


namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = 25;
      if (time < 18) 
      {
        Console.WriteLine("Hello everyone!");
      } 
      else 
      {
        Console.WriteLine("Goodbye people!");
      }
    }
  }
}