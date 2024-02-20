using System;

class task4
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите координаты короля x1y1 и координаты фигуры x2y2");
            string input = Console.ReadLine();
            string[] coordinates = input.Split(' ');


            string knightPosition = coordinates[0];
            string figurePosition = coordinates[1];

            static bool IsValidCoordinate(char x, char y)
            {
                return x >= 'a' && x <= 'h' && y >= '1' && y <= '8';
            }

            char knightXChar = knightPosition[0];
            char knightYChar = knightPosition[1];
            char figureXChar = figurePosition[0];
            char figureYChar = figurePosition[1];


            if (!IsValidCoordinate(knightXChar, knightYChar) || !IsValidCoordinate(figureXChar, figureYChar) ||
                knightPosition.Length != 2 || figurePosition.Length != 2 || coordinates.Length != 2)
            {
                Console.WriteLine("Введены некорректные координаты");
                return;
            }

            int knightX = knightXChar - 'a';
            int knightY = knightYChar - '1';
            int figureX = figureXChar - 'a';
            int figureY = figureYChar - '1';

            if ((Math.Abs(knightX - figureX) == 1) && (Math.Abs(knightY - figureY) == 2)
                || (Math.Abs(knightX - figureX) == 2) && (Math.Abs(knightY - figureY) == 1))
            {
                Console.WriteLine("Конь сможет побить фигуру");
            }
            else
            {
                Console.WriteLine("Конь не сможет побить фигуру");
            }
        }
    }
}