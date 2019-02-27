using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTask
{
	/// <summary>
    /// Точка трехмерного пространства
    /// </summary>
    class Point3D
    {
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;
        public double Z { get; set; } = 0;

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3D operator +(Point3D point1, Point3D point2)
        {
            return new Point3D(point1.X + point2.X, point1.Y + point2.Y, point1.Z + point2.Z);
        }

        public static Point3D operator -(Point3D point1, Point3D point2)
        {
            return new Point3D(point1.X - point2.X, point1.Y - point2.Y, point1.Z - point2.Z);
        }

        public static Point3D operator *(Point3D point, double k)
        {
            return new Point3D(point.X * k, point.Y * k, point.Z * k);
        }

        public static Point3D operator /(Point3D point, double k)
        {
            return new Point3D(point.X / k, point.Y / k, point.Z / k);
        }

        public static explicit operator Point3D(double point)
        {
            return new Point3D(point, point, point);
        }

        public bool Equals(Point3D other)
        {
            return !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || (other.X == X && other.Y == Y && other.Z == Z));
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Point3D);
        }

        public override int GetHashCode()
        {
            return (X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode());
        }

        public static bool operator ==(Point3D point1, Point3D point2)
        {
            return Equals(point1, point2);
        }

        public static bool operator !=(Point3D point1, Point3D point2)
        {
            return !Equals(point1, point2);
        }

        public static bool operator <(Point3D point1, Point3D point2)
        {
            return point1.X < point2.X && point1.Y < point2.Y && point1.Z < point2.Z;
        }

        public static bool operator >(Point3D point1, Point3D point2)
        {
            return point1.X > point2.X && point1.Y > point2.Y && point1.Z > point2.Z;
        }

        public static bool operator <=(Point3D point1, Point3D point2)
        {
            return point1.X <= point2.X && point1.Y <= point2.Y && point1.Z <= point2.Z;
        }

        public static bool operator >=(Point3D point1, Point3D point2)
        {
            return point1.X >= point2.X && point1.Y >= point2.Y && point1.Z >= point2.Z;
        }
    }
}
