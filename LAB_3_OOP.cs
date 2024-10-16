using System;
using System.Text;
using System.Collections.Generic;

class Vector3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Vector3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Введіть кількість векторів: ");
        int numVectors = int.Parse(Console.ReadLine());

        Vector3D[] vectors = new Vector3D[numVectors];

        for (int i = 0; i < numVectors; i++)
        {
            Console.WriteLine($"Введіть координати для вектора {i + 1}:");
            Console.Write("X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Z: ");
            double z = double.Parse(Console.ReadLine());

            vectors[i] = new Vector3D(x, y, z);
        }

        double maxLength = vectors[0].Length();
        List<int> maxIndices = new List<int> { 0 };

        for (int i = 1; i < vectors.Length; i++)
        {
            double length = vectors[i].Length();
            if (length > maxLength)
            {
                maxLength = length;
                maxIndices.Clear();
                maxIndices.Add(i);
            } else if (length == maxLength)
            {
                maxIndices.Add(i);
            }
        }
        Console.WriteLine($"\nМаксимальна довжина вектора: {maxLength}");
        Console.WriteLine("Вектор(и) з найбільшою довжиною:");

        foreach (int index in maxIndices)
        {
            Console.WriteLine($"Вектор {index + 1}: {vectors[index]}");
        }
    }
}