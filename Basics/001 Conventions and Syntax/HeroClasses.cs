//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		
		heroOne.health = 2;
		heroOne.speed = 5;
		heroOne.height = 7;
		heroOne.powerLevel = 5;
		
		heroTwo.health = 3;
		heroTwo.speed = 5;
		heroTwo.height = 3;
		heroTwo.powerLevel = 1;
		
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.speed);
		Console.WriteLine(heroOne.height);
		Console.WriteLine(heroOne.powerLevel);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.speed);
		Console.WriteLine(heroTwo.height);
		Console.WriteLine(heroTwo.powerLevel);
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public int speed;
	public int height;	
}