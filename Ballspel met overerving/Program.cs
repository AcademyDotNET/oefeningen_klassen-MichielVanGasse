using System;
using System.Collections.Generic;

namespace Ballspel_met_overerving
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			Console.WindowHeight = 20;
			Console.WindowWidth = 30;
			Ball b1 = new Ball(4, 4, 1, 0);
			Ball2 b2 = new Ball2(8, 2, 1, 1);
			Ball b3 = new Ball(2, 4, 4, 2);
			Ball2 b4 = new Ball2(2, 3, 5, 3);
			List<Ball> balls = new List<Ball>();
			balls.Add(b1);
			balls.Add(b2);
			balls.Add(b3);
			balls.Add(b4);
			PlayerBall player = new PlayerBall(10, 10, 0, 0);
			int level = 1;
			int score = 0;
			int yourScore = 0;
			while (true)
			{

				Console.Clear();
				Console.WriteLine($"Your level: {level}");
				Console.WriteLine($"Your score: {yourScore}");
				// Ball
				if (level <= balls.Count)
					for (int i = 0; i < level; i++)
					{
						balls[i].Update();
						balls[i].Draw();
					}

				// SpelerBall
				if (Console.KeyAvailable)
				{
					var key = Console.ReadKey();
					player.ChangeVelocity(key);
				}

				player.Update();
				player.Draw();

				// Check collisions
				if (level < balls.Count)
				{
					for (int i = 0; i < level; i++)
					{
						if (Ball.CheckHit(balls[i], player))
						{
							yourScore += score;
							score = 0;
							level++;
						}
						for (int j = 0; j < balls.Count; j++)
						{
							if (i != j)
							{
								if (Ball.CheckHit(balls[i], balls[j]))
								{
									Console.SetCursorPosition(20, 0);
									Console.WriteLine("BallCollision");
								}
							}
						}
					}
				}
				else
				{
					Console.Clear();
					Console.WriteLine("Gewonnen!");
					Console.ReadLine();
				}

				System.Threading.Thread.Sleep(100);
				score++;
			}
		}
	}
}
