using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;


namespace Змейка
{
    class Elements
    {
        public static Walls walls;
        public static Snake snake;
        public static Food food;
    }
    class Game
    {
        static void Main()
        {
            Console.CursorVisible = false; //скрывает курсор в консоли
            int x = 0, y = 0; //границы массива
            int snake_speed = 0; //скорость змейки
            Console.WriteLine("Выберите уровень сложности:" +"\n1 - Легкий" +"\n2 - Средний" +"\n3 - Сложный"); //выбор уровня сложности
            int Level = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (Level)
            {
                case 1:
                x = 10;
                y = 10;
                snake_speed = 500;
                break;
                case 2:
                x = 15;
                y = 15;
                snake_speed = 200;
                break;
                case 3:
                x = 20;
                y = 20;
                snake_speed = 100;
                break;

            }
        }
    }
}
