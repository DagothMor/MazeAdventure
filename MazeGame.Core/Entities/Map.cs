using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGame.Core.Entities
{
	public class Map
	{
		int[,] array = new int[2,2] { { 1,2},
									  { 3,4} };

		/// <summary>
		/// Todo: Create a map generator
		/// </summary>
		public Map()
		{
			
		}
		public void Display()
		{
			for (int i = 0; i < this.array.GetLength(0); i++)
			{
				for (int j = 0; j < this.array.GetLength(1); j++)
				{
					Console.Write(array[i,j]);
					Console.Write("|");
				}
				Console.WriteLine("");
				Console.WriteLine("--------------");
			}
		}
	}
}
