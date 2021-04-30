using System;
using System.Collections.Generic;

namespace Mapmaker
{
	class Program
	{
		static void Main(string[] args)
		{
            //List<MapObject> allObjects = new List<MapObject>();
            //allObjects.Add(new SalonElement(new Point(5, 5)));
            //allObjects[0].Paint();

            //Verplaats salon
            //allObjects[0].Location = new Point(10, 10);
            //allObjects[0].Paint();

            //DrawSalonElement();
            //Test();
             DrawMenu();
        }
		public static void Test()
		{
            List<MapObject> allObjects = new List<MapObject>(); //lang leve polymorfisme

            //Muurtje
            for (int i = 0; i < 10; i++)
            {
                Point tempLoc = new Point(2 + i, 3);
                WallElement tempWall = new WallElement(tempLoc, '=', 10.0);
                allObjects.Add(tempWall);
            }

            //Zetel
            allObjects.Add(new ZetelElement(new Point(6, 8), 3));

            //Teken alle objecten
            for (int i = 0; i < allObjects.Count; i++)
            {
                allObjects[i].Paint();
            }
        }
        public static void DrawMenu()
		{
            List<MapObject> allObjects = new List<MapObject>();
            Menu menu = new Menu();
            do
            {
                menu.ShowMenu();
                menu.GetInput(allObjects);
                Console.Clear();
                //Teken alle objecten
                for (int i = 0; i < allObjects.Count; i++)
                {
                    allObjects[i].Paint();
                }
            } while (true);
        }
        public static void DrawSalonElement()
		{
            SalonElement salon1 = new SalonElement(new Point(6, 5));
            salon1.Paint();
        }
	}
}
