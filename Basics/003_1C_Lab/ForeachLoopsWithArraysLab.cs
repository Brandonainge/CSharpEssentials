using System;

public class Program
{
	public static void Main()
	{
		armor[] armorObjs = {new armor(), new armor(), new armor(), new armor()};
		armorObjs[1].armorName = "Chestplate";
		armorObjs[2].armorName = "Pants";
		armorObjs[3].armorName = "Boots";
		
		for(var i=0; i<armorObjs.Length; i++) {
			armorObjs[i].armorStrength = 4;
		}
	
		foreach(var item in armorObjs){
			Console.WriteLine(item.armorName);
			Console.WriteLine(item.armorStrength);
		}
	}
}

public class armor {
	public string armorName = "Helmet";
	public int armorStrength = 1;
	
}
