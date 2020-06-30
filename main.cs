using System;

class MainClass {
  public static void Main (string[] args) {

  int counter = 0;
  double total = 0;

Console.WriteLine("How many drivers participated in the race?");
int numberOfDrivers = Convert.ToInt32(Console.ReadLine());

while(counter < numberOfDrivers)
{
  Console.WriteLine("Enter the distance traveled (in miles)");
  double distance = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("The distance traveled was " + distance + " miles.");
  
  Console.WriteLine("Enter the time taken");
  double time = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("The time taken was " + time + " hours.");

  double speed = distance / time;
  Console.WriteLine("This vehicle traveled at " + speed + " miles per hour.");
  total = total + speed;
Console.WriteLine(" "); //Putting a gap between each entry; looks neater :)
  counter++;
}

double average = total / counter;
Console.WriteLine("The average speed for all vehicles is " + average + " miles per hour.");

  }
}