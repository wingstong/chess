using System;

class task3
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите координаты ферзя x1y1 и координаты фигуры x2y2");
            string input = Console.ReadLine();
            string[] coordinates = input.Split(' ');


            string queenPosition = coordinates[0];
            string figurePosition = coordinates[1];

            static bool IsValidCoordinate(char x, char y)
            {
                return x >= 'a' && x <= 'h' && y >= '1' && y <= '8';
            }

            char queenXChar = queenPosition[0];
            char queenYChar = queenPosition[1];
            char figureXChar = figurePosition[0];
            char figureYChar = figurePosition[1];

            if (!IsValidCoordinate(queenXChar, queenYChar) || !IsValidCoordinate(figureXChar, figureYChar) ||
                queenPosition.Length != 2 || figurePosition.Length != 2 || coordinates.Length != 2)
            {
                Console.WriteLine("Введены некорректные координаты");
                return;
            }

            int queenX = queenXChar - 'a';
            int queenY = queenYChar - '1';
            int figureX = figureXChar - 'a';
            int figureY = figureYChar - '1';

            if (Math.Abs(queenX - figureX) == Math.Abs(queenY - figureY) || (queenX == figureX || queenY == figureY))
            {
                Console.WriteLine("Ферзь сможет побить фигуру");
            }
            else
            {
                Console.WriteLine("Ферзь не сможет побить фигуру");
            }
        }
    }
}
