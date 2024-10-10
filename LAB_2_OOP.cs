using System;
using System.Text;

public class Vector3D
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

    public double GetLength()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }
}

class LAB_2_OOP
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть координати тривимірного вектора:");

        Console.Write("Введіть X: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введіть Y: ");
        double y = double.Parse(Console.ReadLine());

        Console.Write("Введіть Z: ");
        double z = double.Parse(Console.ReadLine());

        // Створення об'єкта класу Vector3D
        Vector3D vector = new Vector3D(x, y, z);

        Console.WriteLine($"Вектор: ({vector.X}, {vector.Y}, {vector.Z})");

        double length = vector.GetLength();
        Console.WriteLine($"Довжина вектора: {length}");
    }
}