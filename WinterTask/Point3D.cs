﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTask
{
	/// <summary>
    /// Точка трехмерного пространства
    /// </summary>
    public class Point3D
    {
        private double X { get; }
        private double Y { get; }
        private double Z { get; }

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

        private bool Equals(Point3D other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == GetType() && Equals((Point3D)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ Z.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Point3D left, Point3D right)
        {
            return !Equals(left, right);
        }
    }
}
