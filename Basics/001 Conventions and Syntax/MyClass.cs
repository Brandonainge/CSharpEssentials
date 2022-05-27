//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
using System;
					
public class Program
{
    public Character characterOne;
    public Character characterTwo;
	
    public void Main()
    {
        characterOne = new Character();
        characterTwo = new Character();
		
		characterOne.stamina = 100;
		characterOne.intelligence = 200;
        characterOne.magic = 30;
        characterOne.strength = 50;
        characterOne.energy = 100;
        characterOne.size = 6;
		
		characterTwo.stamina = 200;
		characterTwo.intelligence = 100;
        characterTwo.magic = 60;
        characterTwo.strength = 20;
        characterTwo.energy = 150;
        characterTwo.size = 4;
		
		
		Console.WriteLine(characterOne.stamina);
		Console.WriteLine(characterOne.intelligence);
        Console.WriteLine(characterOne.magic);
        Console.WriteLine(characterOne.strength);
        Console.WriteLine(characterOne.energy);
        Console.WriteLine(characterOne.size);
		
		Console.WriteLine(characterTwo.stamina);
		Console.WriteLine(characterTwo.intelligence);
        Console.WriteLine(characterTwo.magic);
        Console.WriteLine(characterTwo.strength);
        Console.WriteLine(characterTwo.energy);
        Console.WriteLine(characterTwo.size);
       
    }
}

public class Character {
    public int stamina;
    public int intelligence;
    public int magic;
    public int strength;
    public int energy;
    public int size;
}