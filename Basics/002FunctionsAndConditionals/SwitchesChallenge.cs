// The Expectation is that you write your own code based
// on what you have learned in the class, it can be what you want
// If you are havind trouble thinking of something, write conditionals
// with the topic of PowerUps, what happens if the powerUp is good or bad.



using System;
					
public class Program
{
	public PowerUp powerUp;
	
	public void Main()
	{
		powerUp = new PowerUp();
		powerUp.currentState = GameStates.States.Ending;
		powerUp.CheckState();
	}
}

public class GameStates {
	
	public enum States {
		Starting,
		Playing,
		Ending
	}
	
	public States currentState = States.Starting;
	
	public void CheckState () {
		switch (currentState) {
			case States.Starting:
				Console.WriteLine("Starting");
				break;
			case States.Playing:
				Console.WriteLine("Playing");
				break;
			case States.Ending:
				Console.WriteLine("Ending");
				break;
		}
	}
}
