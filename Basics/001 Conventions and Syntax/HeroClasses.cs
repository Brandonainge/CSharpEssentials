//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Villain villainOne;
	public Villain villainTwo;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		villainOne = new Villain();
		villainTwo = new Villain();
		
		heroOne.health = 2;
		heroOne.speed = 5;
		heroOne.height = 7;
		heroOne.powerLevel = 5;
		
		heroTwo.health = 3;
		heroTwo.speed = 5;
		heroTwo.height = 3;
		heroTwo.powerLevel = 1;

		villainOne.health = 100;
		villainOne.speed = 500;
		villainOne.height = 30;
		villainOne.powerLevel = 100;

		villainTwo.health = 200;
		villainTwo.speed = 1;
		villainTwo.height = 100;
		villainTwo.powerLevel = 200;
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.speed);
		Console.WriteLine(heroOne.height);
		Console.WriteLine(heroOne.powerLevel);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.speed);
		Console.WriteLine(heroTwo.height);
		Console.WriteLine(heroTwo.powerLevel);

		Console.WriteLine(villainOne.health);
		Console.WriteLine(villainOne.speed);
		Console.WriteLine(villainOne.height);
		Console.WriteLine(villainOne.powerLevel);


		Console.WriteLine(villainTwo.health);
		Console.WriteLine(villainTwo.speed);
		Console.WriteLine(villainTwo.height);
		Console.WriteLine(villainTwo.powerLevel);

	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public int speed;
	public int height;	
}

public class Villain {
	public int health;
	public int powerLevel;
	public int speed;
	public int height;
}