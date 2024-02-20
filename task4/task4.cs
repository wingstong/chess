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


            string kingPosition = coordinates[0];
            string figurePosition = coordinates[1];

            static bool IsValidCoordinate(char x, char y)
            {
                return x >= 'a' && x <= 'h' && y >= '1' && y <= '8';
            }

            char kingXChar = kingPosition[0];
            char kingYChar = kingPosition[1];
            char figureXChar = figurePosition[0];
            char figureYChar = figurePosition[1];


            if (!IsValidCoordinate(kingXChar, kingYChar) || !IsValidCoordinate(figureXChar, figureYChar) ||
                kingPosition.Length != 2 || figurePosition.Length != 2 || coordinates.Length != 2)
            {
                Console.WriteLine("Введены некорректные координаты");
                return;
            }

            int kingX = kingXChar - 'a';
            int kingY = kingYChar - '1';
            int figureX = figureXChar - 'a';
            int figureY = figureYChar - '1';

            if ((Math.Abs(kingX - figureX) <= 1) && (Math.Abs(kingY - figureY) <= 1))
            {
                Console.WriteLine("Король сможет побить фигуру");
            }
            else
            {
                Console.WriteLine("Король не сможет побить фигуру");
            }
        }
    }
}