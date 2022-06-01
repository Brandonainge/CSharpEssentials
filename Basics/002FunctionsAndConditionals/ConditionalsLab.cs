using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Welcome");
		myOperator.DoMath(1, 4);
		myOperator.DoMath(20, 76);
		myOperator.DoMath(10, 15);
		myOperator.Compare(400,31);
		myOperator.Compare(13,74);
		myOperator.CheckPassword("SevenOF9");
		myOperator.CheckPassword("confused37");
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
		if(password == "confused37") {
			Console.WriteLine("Incorrect Password");
		} else {
			Console.WriteLine("Correct Password");	
		}
	}
}
 