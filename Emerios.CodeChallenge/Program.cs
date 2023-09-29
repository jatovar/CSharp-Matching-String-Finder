using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Read the matrix from a text file
        char[,] matrix = ReadMatrixFromFile("matrix.txt");

        // Find the longest matching adjacent characters
        string longestString = FindLongestSequence(matrix);

        // Print the longest string
        Console.WriteLine(longestString);
        Console.ReadLine();
    }

    static char[,] ReadMatrixFromFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        int rows = lines.Length;
        int columns = lines[0].Split(',').Length;
        char[,] matrix = new char[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            string[] characters = lines[i].Split(',').Select(s => s.Trim()).ToArray();

            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = characters[j][0];
            }
        }

        return matrix;
    }

    static string FindLongestSequence(char[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);
        int maxLength = 0;
        string longestSequence = "";

        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                char currentChar = matrix[row, col];

                if (currentChar != '\0')
                {
                    string sequence = FindLongestSequenceFromCell(matrix, numRows, numCols, row, col);

                    if (sequence.Length > maxLength)
                    {
                        maxLength = sequence.Length;
                        longestSequence = sequence;
                    }
                }
            }
        }

        return longestSequence;
    }

    static string FindLongestSequenceFromCell(char[,] matrix, int numRows, int numCols, int row, int col)
    {
        char currentChar = matrix[row, col];
        int[][] directions = {
            new int[] { 1, 0 }, new int[] { -1, 0 }, // Vertical
            new int[] { 0, 1 }, new int[] { 0, -1 }, // Horizontal
            new int[] { 1, 1 }, new int[] { -1, -1 }, // Diagonal superior
            new int[] { 1, -1 }, new int[] { -1, 1 } // Diagonal inferior
        };
        int maxLength = 0;
        string longestSequence = "";

        foreach (var direction in directions)
        {
            int dx = direction[0];
            int dy = direction[1];
            string sequence = currentChar.ToString();
            int length = 1;

            while (true)
            {
                int newRow = row + dx;
                int newCol = col + dy;

                if (newRow >= 0 && newRow < numRows && newCol >= 0 && newCol < numCols)
                {
                    char nextChar = matrix[newRow, newCol];

                    if (nextChar == currentChar)
                    {
                        sequence += nextChar;
                        length++;
                        row = newRow;
                        col = newCol;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            if (length > maxLength)
            {
                maxLength = length;
                longestSequence = sequence;
            }
        }

        return longestSequence;
    }
}
