namespace WinterTask
{
    /// <summary>
    ///     Точка трехмерного пространства
    /// </summary>
    public class Point3D
    {
        #region Properties

        /// <summary>
        ///     Координата X
        /// </summary>
        private double X { get; }

        /// <summary>
        ///     Координата Y
        /// </summary>
        private double Y { get; }

        /// <summary>
        ///     Координата Z
        /// </summary>
        private double Z { get; }

        #endregion

        #region Constructor

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Перегрузка метода Equals для Point3D
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        private bool Equals(Point3D other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        #endregion

        #region Public methods

        /// <summary>
        ///     Перегрузка оператора сложения
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static Point3D operator +(Point3D point1, Point3D point2)
        {
            return new Point3D(point1.X + point2.X, point1.Y + point2.Y,
                point1.Z + point2.Z);
        }

        /// <summary>
        ///     Перегрузка оператора разности
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static Point3D operator -(Point3D point1, Point3D point2)
        {
            return new Point3D(point1.X - point2.X, point1.Y - point2.Y,
                point1.Z - point2.Z);
        }

        /// <summary>
        ///     Перегрузка оператора умножения
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static Point3D operator *(Point3D point, double k)
        {
            return new Point3D(point.X * k, point.Y * k, point.Z * k);
        }

        /// <summary>
        ///     Перегрузка оператора деления
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static Point3D operator /(Point3D point, double k)
        {
            return new Point3D(point.X / k, point.Y / k, point.Z / k);
        }

        /// <summary>
        ///     Перегрузка явного преобразования из double
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static explicit operator Point3D(double point)
        {
            return new Point3D(point, point, point);
        }

        /// <summary>
        ///     Перегрузка оператора сравнения "меньше"
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static bool operator <(Point3D point1, Point3D point2)
        {
            return point1.X < point2.X && point1.Y < point2.Y && point1.Z < point2.Z;
        }

        /// <summary>
        ///     Перегрузка оператора сравнения "больше"
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static bool operator >(Point3D point1, Point3D point2)
        {
            return point1.X > point2.X && point1.Y > point2.Y && point1.Z > point2.Z;
        }

        /// <summary>
        ///     Перегрузка оператора сравнения "меньше или равно"
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static bool operator <=(Point3D point1, Point3D point2)
        {
            return point1.X <= point2.X && point1.Y <= point2.Y && point1.Z <= point2.Z;
        }

        /// <summary>
        ///     Перегрузка оператора сравнения "больше или равно"
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static bool operator >=(Point3D point1, Point3D point2)
        {
            return point1.X >= point2.X && point1.Y >= point2.Y && point1.Z >= point2.Z;
        }

        /// <summary>
        ///     Перегрузка метода Equals для объекта
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
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

            return obj.GetType() == GetType() && Equals((Point3D) obj);
        }

        /// <summary>
        ///     Перегрузка метода GetHashCode
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
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

        /// <summary>
        ///     Перегрузка оператора сравнения "равно"
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static bool operator ==(Point3D left, Point3D right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Перегрузка оператора сравнения "не равно"
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static bool operator !=(Point3D left, Point3D right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}