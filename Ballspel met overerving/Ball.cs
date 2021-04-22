﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballspel_met_overerving
{
	class Ball
	{
        public int X { get { return x; } }
        public int Y { get { return y; } }
        protected int x = 0;
        protected int y = 0;
        protected int vx = 0;
        protected int vy = 0;
        protected char drawChar = 'O';
        protected ConsoleColor drawColor = ConsoleColor.Red;

        public Ball(int xin, int yin, int vxin, int vyin)
        {
            x = xin;
            y = yin;
            vx = vxin;
            vy = vyin;
        }

        public void Update()
        {
            x += vx;
            y += vy;
            if (x >= Console.WindowWidth || x < 0)
            {
                vx *= -1;
                x += vx;
            }
            if (y >= Console.WindowHeight || y < 0)
            {
                vy *= -1;
                y += vy;
            }
        }
        public virtual void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = drawColor;
            Console.Write(drawChar);
            Console.ResetColor();

        }

        static public bool CheckHit(Ball ball1, Ball ball2)
        {

            if (ball1.X == ball2.X && ball1.Y == ball2.Y)
                return true;

            return false;
        }
    }
}
