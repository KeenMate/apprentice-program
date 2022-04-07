using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProgressBar3000
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.CursorVisible = false;
			Console.WriteLine();
			for (int i = 0; i < 30; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Console.SetCursorPosition(Console.CursorLeft > 0 ? Console.CursorLeft - 1 : 0, Math.Max(0, Console.CursorTop - 1));
					if (j < 3)
						Console.Write("\u2591");
					else if (j < 6)
						Console.Write("\u2592");
					else
						Console.Write("\u2593");

					Thread.Sleep(100);
				}

				Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
			}
		}
	}
}
