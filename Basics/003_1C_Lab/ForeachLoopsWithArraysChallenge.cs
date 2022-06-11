using System;

public class Program
{
	public static void Main()
	{
		enemy[] enemyCharacter = {new enemy(), new enemy(), new enemy(), new enemy()};
		enemyCharacter[1].enemyName = "Dragon";
		enemyCharacter[2].enemyName = "Grunt";
		enemyCharacter[3].enemyName = "Warlock";
		
		for(var i=0; i<enemyCharacter.Length; i++) {
			enemyCharacter[i].enemyStrength = 10;
		}
	
		foreach(var item in enemyCharacter){
			Console.WriteLine(item.enemyName);
			Console.WriteLine(item.enemyStrength);
			Console.WriteLine(item.enemyHealth);
		}
	}
}

public class enemy {
	public string enemyName = "Mega Dragon";
	public int enemyStrength = 0;
	public int enemyHealth = 30;
	
}