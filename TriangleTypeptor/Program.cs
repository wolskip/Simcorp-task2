using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// The main program class for determining the type of a triangle based on its side lengths.
/// </summary>
public class Program
{
    /// <summary>
    /// The entry point of the program.
    /// </summary>
    /// <param name="args">An array of strings representing the side lengths of the triangle.</param>
    static public void Main(string[] args)
    {
        // Validate input: Ensure exactly three integer side lengths are provided.
        if (args.Length != 3 || !args.All(arg => int.TryParse(arg, out _)))
        {
            Console.WriteLine("Invalid input. Please provide exactly three integer side lengths.");
            return;
        }

        var sides = args.Select(int.Parse).ToArray();
        Array.Sort(sides);

        // Check if the sides form a valid triangle.
        if (sides[0] + sides[1] <= sides[2])
        {
            Console.WriteLine("Not a triangle");
            return;
        }

        // Determine the type of triangle based on the number of unique side lengths.
        var uniqueSides = new HashSet<int>(sides).Count;
        Console.WriteLine("The type of triangle is: " + GetTriangleType(uniqueSides));
    }

    /// <summary>
    /// Determines the type of a triangle based on the number of unique side lengths.
    /// </summary>
    /// <param name="count">The number of unique side lengths.</param>
    /// <returns>
    /// A string representing the type of the triangle:
    /// "Equilateral", "Isosceles", "Scalene", or "Not a triangle".
    /// </returns>
    private static string GetTriangleType(int count)
    {
        return count switch
        {
            1 => "Equilateral",
            2 => "Isosceles",
            3 => "Scalene",
            _ => "Not a triangle"
        };
    }

    /// <summary>
    /// Runs a set of predefined test cases to validate the triangle type detection logic.
    /// </summary>
    public static void Test()
    {
        var testCases = new Dictionary<int[], string>
        {
            { new[] { 3, 3, 3 }, "Equilateral" },
            { new[] { 3, 3, 4 }, "Isosceles" },
            { new[] { 3, 4, 5 }, "Scalene" },
            { new[] { 1, 2, 3 }, "Not a triangle" },
            { new[] { 5, 1, 1, 3 }, "Not a triangle" }
        };

        foreach (var testCase in testCases)
        {
            var sides = testCase.Key;
            Array.Sort(sides);

            string result;
            // Check if the sides form a valid triangle.
            if (sides[0] + sides[1] <= sides[2])
            {
                result = "Not a triangle";
            }
            else
            {
                // Determine the type of triangle based on the number of unique side lengths.
                var uniqueSides = new HashSet<int>(sides).Count;
                result = GetTriangleType(uniqueSides);
            }

            Console.WriteLine($"Sides: {string.Join(", ", sides)} => Expected: {testCase.Value}, Got: {result}");
        }
    }
}
