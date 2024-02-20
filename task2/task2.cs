using System;

class task2
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите координаты слона x1y1 и координаты фигуры x2y2");
            string input = Console.ReadLine();
            string[] coordinates = input.Split(' ');


            string bishopPosition = coordinates[0];
            string figurePosition = coordinates[1];

            static bool IsValidCoordinate(char x, char y)
            {
                return x >= 'a' && x <= 'h' && y >= '1' && y <= '8';
            }

            char bishopXChar = bishopPosition[0];
            char bishopYChar = bishopPosition[1];
            char figureXChar = figurePosition[0];
            char figureYChar = figurePosition[1];

            if (!IsValidCoordinate(bishopXChar, bishopYChar) || !IsValidCoordinate(figureXChar, figureYChar) ||
                bishopPosition.Length != 2 || figurePosition.Length != 2 || coordinates.Length != 2)
            {
                Console.WriteLine("Введены некорректные координаты");
                return;
            }

            int bishopX = bishopXChar - 'a';
            int bishopY = bishopYChar - '1';
            int figureX = figureXChar - 'a';
            int figureY = figureYChar - '1';

            if (Math.Abs(bishopX - figureX) == Math.Abs(bishopY - figureY))
            {
                Console.WriteLine("Слон сможет побить фигуру");
            }
            else
            {
                Console.WriteLine("Слон не сможет побить фигуру");
            }
        }
    }
}
