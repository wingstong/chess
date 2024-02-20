using System;

class task1
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите координаты ладьи x1, y1 и координаты фигуры x2, y2");
            string input = Console.ReadLine();
            string[] coordinates = input.Split(' ');

            string ladPosition = coordinates[0];
            string figurePosition = coordinates[1];

            static bool IsValidCoordinate(char x, char y)
            {
                return x >= 'a' && x <= 'h' && y >= '1' && y <= '8';
            }

            char ladXChar = ladPosition[0];
            char ladYChar = ladPosition[1];
            char figureXChar = figurePosition[0];
            char figureYChar = figurePosition[1];

            if (!IsValidCoordinate(ladXChar, ladYChar) || !IsValidCoordinate(figureXChar, figureYChar) ||
                ladPosition.Length != 2 || figurePosition.Length != 2 || coordinates.Length != 2)
            {
                Console.WriteLine("Введены некорректные координаты");
                return;
            }

            int ladX = ladXChar - 'a';
            int ladY = ladYChar - '1';
            int figureX = figureXChar - 'a';
            int figureY = figureYChar - '1';

            if (ladX == figureX || ladY == figureY)
            {
                Console.WriteLine("Ладья сможет побить фигуру");
            }
            else
            {
                Console.WriteLine("Ладья не сможет побить фигуру");
            }
        }

    }
}
