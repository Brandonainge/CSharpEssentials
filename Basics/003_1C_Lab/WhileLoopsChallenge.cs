using System;

 public class Program
 {
   public static void Main(string[] args)
   {
     int i = 3;
     do 
     {
       Console.WriteLine(i);
        i++;
		i = i + 3;
     }
     while (i < 600);
   }
 }