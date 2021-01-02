using MazeGame.Core.Entities;
using System;
using System.Security.Cryptography.X509Certificates;

namespace MazeGame.Core
{
	class Program
	{
		/// <summary>
		/// i'm gonna create a maze game which have a map redactor and algorithms to solve maps
		/// well maybe the first i need a main menu
		/// TODO: Create main menu,it has a exit/start game
		/// </summary>
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Welcome to the MazeGame!");
				Console.WriteLine("Main menu:" +
					"1-Start New Game!" +
					"2-Exit");
				var input = Console.ReadLine();
				if (int.Parse(input) == 2)
				{
					Environment.Exit(0);
				}//exit from game.
				else if (int.Parse(input) == 1)//Start new game.
				{
					NewGame();
				}
				Console.Clear();
			}
		}
		
		/// <summary>
		/// Need to create a matrix and displayed it
		/// 1.Create a class Map
		/// </summary>
		public static void NewGame()
		{
			Map map = new Map();
			map.Display();
			Console.ReadLine();
		}
	}
}
