namespace OOP05;

    using System;
using System.Security.Cryptography.X509Certificates;
#region Project 1
public class Point3D : IComparable, ICloneable
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    public Point3D(double x, double y, double z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    public override string ToString()
    {
        return $"Point3D({X}, {Y}, {Z})";
    }
    public void ReadCoordinates()
    {
        try
        {   //point 1
            Console.WriteLine("Enter the point X to P1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the point Y to P1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the point Z to P1: ");
            double z1 = double.Parse(Console.ReadLine());
            //point 2
            Console.WriteLine("Enter the point X to P2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the point Y to P2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the point Z to P2: ");
            double z2 = double.Parse(Console.ReadLine());
            //instaance for points
            Point3D p1 = new Point3D(x1, y1, z1);
            Point3D p2 = new Point3D(x2, y2, z2);

            //output
            Console.WriteLine($"P1: {p1}");
            Console.WriteLine($"P2: {p2}");

            //IF
            if (p1 == p2) Console.WriteLine("The points are equal.");
            else
                Console.WriteLine("The points are not equal.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
        
    }
    //bool operator i think
    public static bool operator ==(Point3D p1, Point3D p2)
    {   if(ReferenceEquals(p1, p2)) return true;
        if(ReferenceEquals(p1, null) || ReferenceEquals(p2, null)) return false;
        return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
    }
    public static bool operator !=(Point3D p1, Point3D p2)
    {
        return !(p1 == p2);
    }
    //compare to method
    public int CompareTo(object? obj)
    {
        if (obj == null) return 1;
        if (obj is Point3D otherPoint)
        {
            double distance1 = Math.Sqrt(X * X + Y * Y + Z * Z);
            double distance2 = Math.Sqrt(otherPoint.X * otherPoint.X + otherPoint.Y * otherPoint.Y + otherPoint.Z * otherPoint.Z);
            return distance1.CompareTo(distance2);
        }
        throw new ArgumentException("Object is not a Point3D");
    }
    public object Clone()
    {
        return new Point3D(this.X, this.Y, this.Z);
    }
}
#endregion
public class Program
{
    public static void Main(string[] args)
    {
        #region Project 1
        //making new instances
        Point3D point = new Point3D(10, 10, 10);
        Console.WriteLine(point.ToString());
        //array of points
        Point3D[] points = new Point3D[]
        {
            new Point3D(1, 2, 3),
            new Point3D(4, 5, 6),
            new Point3D(7, 8, 9)
        };
        //sorting them
        Array.Sort(points);
        Console.WriteLine("Sorted points: ");
        //foreach
        foreach (var p in points)
        {
            Console.WriteLine(p.ToString());
        }
        //making 2 versions one for original point anad the other is the clone version
        Point3D originalPoint = new Point3D(1, 2, 3);
        Console.WriteLine(originalPoint.ToString());
        Point3D clonedPoint = (Point3D)originalPoint.Clone();
        Console.WriteLine(clonedPoint.ToString());
        #endregion
    }
}