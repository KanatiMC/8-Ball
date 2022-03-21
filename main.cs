using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
		bool redo = true;
		while(redo){
		Console.WriteLine("What Would Like To Ask The Magic Eight Ball?");
    string readString = Console.ReadLine();
		int randomizeInt = Program.randomNum(1) + Program.randomNum(1) + 2;
			Console.WriteLine(randomizeInt.ToString());
		if (randomizeInt == 1){
			Console.WriteLine("You May Rely On It.");
		}
		if (randomizeInt == 2)
		{
			Console.WriteLine("It Is Certain.");
		}
		if (randomizeInt == 3){
			Console.WriteLine("Without A Doubt.");
		}
		if (randomizeInt == 4)
		{
			Console.WriteLine("Yes, Definitely.");
		}
		if (randomizeInt == 5){
			Console.WriteLine("As I See It, Yes.");
		}
		if (randomizeInt == 6)
		{
			Console.WriteLine("Most Likely.");
		}
			if (randomizeInt == 7)
		{
			Console.WriteLine("Outlook Is Good.");
		}
			if (randomizeInt == 8)
		{
			Console.WriteLine("Yes.");
		}
			if (randomizeInt == 9)
		{
			Console.WriteLine("Signs To Point Yes.");
		}
			if (randomizeInt == 10)
		{
			Console.WriteLine("Reply Hazey, Try Again.");
		}
			if (randomizeInt == 11)
		{
			Console.WriteLine("Ask Again Later.");
		}
			if (randomizeInt == 12)
		{
			Console.WriteLine("Better Not To Tell You Now.");
		}
			if (randomizeInt == 13)
		{
			Console.WriteLine("Unable To Predict Now.");
		}
			if (randomizeInt == 14)
		{
			Console.WriteLine("Concentrate And Ask Again.");
		}
			if (randomizeInt == 15)
		{
			Console.WriteLine("Don't Count On It.");
		}
			if (randomizeInt == 16)
		{
			Console.WriteLine("My Reply Is No.");
		}
			if (randomizeInt == 17)
		{
			Console.WriteLine("My Sources Say No.");
		}
			if (randomizeInt == 18)
		{
			Console.WriteLine("Outlook Is Not Well.");
		}
			if (randomizeInt == 19)
		{
			Console.WriteLine("Very Doubtfull.");
		}
			if (randomizeInt == 20)
		{
			Console.WriteLine("It Is Decidedly So.");
		}
		Console.WriteLine("\n\nWould You Like To Restart The 8-Ball? (y/n)");
		string readingLine = Console.ReadLine();
		if (readingLine.Contains("y"))
		{
			redo = true;
		}
		else {
			if (readingLine.Contains("n")){
				redo = false;
			}
			else {
				Console.WriteLine("Syntax Error: Invalid Character, You Can Only Use \"y\" And \"n\"");
				redo = false;
			}
		}
		}
  }
	 public static int randomNum(int length)
  {
    const string chars = "123456789";
    return int.Parse(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
  }
    private static Random random = new Random();
}