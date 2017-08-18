using System;

public class Program
{
	public interface IHelloWorld
	{
		string getMessage();
		void display();
	}

	public class HelloWorld : IHelloWorld
	{
		private string message;

		public HelloWorld()
		{
			message = "Hello world";
		}

		public string getMessage()
		{
			return message;
		}

		public void display()
		{
			Console.WriteLine(getMessage());
		}
	}


	public static void Main()
	{
		var hw = new HelloWorld();
		hw.display();
	}
}
