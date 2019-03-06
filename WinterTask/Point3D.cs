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
        /// <param name="x"> координата х </param>
        /// <param name="y"> координата у </param>
        /// <param name="z"> координата z </param>
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
        /// <param name="otherPoint">Точка с которой производится сравнение</param>
        /// <returns>True если координаты равны, в другом случае - false</returns>
        private bool Equals(Point3D otherPoint)
        {
            return X.Equals(otherPoint.X) && Y.Equals(otherPoint.Y) &&
                   Z.Equals(otherPoint.Z);
        }

        #endregion

        #region Public methods

        /// <summary>
        ///     Перегрузка оператора сложения
        /// </summary>
        /// <param name="point1">Точка 1 - первый элемент суммы</param>
        /// <param name="point2">Точка 2 - второй элемент суммы</param>
        /// <returns>Точку, которая является результатом суммы двух точек</returns>
        public static Point3D operator +(Point3D point1, Point3D point2)
        {
            return new Point3D(point1.X + point2.X, point1.Y + point2.Y,
                point1.Z + point2.Z);
        }

        /// <summary>
        ///     Перегрузка оператора разности
        /// </summary>
        /// <param name="point1">Точка 1 - первый элемент разности</param>
        /// <param name="point2">Точка 2 - первый элемент разности</param>
        /// <returns>Точку, которая является результатом разности двух точек</returns>
        public static Point3D operator -(Point3D point1, Point3D point2)
        {
            return new Point3D(point1.X - point2.X, point1.Y - point2.Y,
                point1.Z - point2.Z);
        }

        /// <summary>
        ///     Перегрузка оператора умножения
        /// </summary>
        /// <param name="point">Множимое</param>
        /// <param name="k">Множитель</param>
        /// <returns>Точку, координаты которой умножены на коэфицент k</returns>
        public static Point3D operator *(Point3D point, double k)
        {
            return new Point3D(point.X * k, point.Y * k, point.Z * k);
        }

        /// <summary>
        ///     Перегрузка оператора деления
        /// </summary>
        /// <param name="point">Точка которую требуется разделить</param>
        /// <param name="k">Делитель</param>
        /// <returns>Точку, координаты которой были поделены на коэфицент k</returns>
        public static Point3D operator /(Point3D point, double k)
        {
            return new Point3D(point.X / k, point.Y / k, point.Z / k);
        }

        /// <summary>
        ///     Перегрузка явного преобразования из double
        /// </summary>
        /// <param name="point">Число которое будет преобразовано в точку</param>
        /// <returns>Точку, все координаты которой равны входному параметру point</returns>
        public static explicit operator Point3D(double point)
        {
            return new Point3D(point, point, point);
        }

        /// <summary>
        ///     Перегрузка оператора сравнения "меньше"
        /// </summary>
        /// <param name="point1">Левый элемент сравнения</param>
        /// <param name="point2">Правый элемент сравнения</param>
        /// <returns>
        ///     Если все координаты первой точки меньше чем координаты второй, возвращается true, в любом другом случае -
        ///     false
        /// </returns>
        public static bool operator <(Point3D point1, Point3D point2)
        {
            return point1.X < point2.X && point1.Y < point2.Y && point1.Z < point2.Z;
        }

        /// <summary>
        ///     Перегрузка оператора сравнения "больше"
        /// </summary>
        /// <param name="point1">Левый элемент сравнения</param>
        /// <param name="point2">Правый элемент сравнения</param>
        /// <returns>
        ///     Если все координаты первой точки больше чем координаты второй, возвращается true, в любом другом случае -
        ///     false
        /// </returns>
        public static bool operator >(Point3D point1, Point3D point2)
        {
            return point1.X > point2.X && point1.Y > point2.Y && point1.Z > point2.Z;
        }

        /// <summary>
        ///     Перегрузка оператора сравнения "меньше или равно"
        /// </summary>
        /// <param name="point1">Левый элемент сравнения</param>
        /// <param name="point2">Правый элемент сравнения</param>
        /// <returns>
        ///     Если все координаты первой точки меньше или равны координатам второй, возвращается true, в любом другом случае
        ///     - false
        /// </returns>
        public static bool operator <=(Point3D point1, Point3D point2)
        {
            return point1.X <= point2.X && point1.Y <= point2.Y && point1.Z <= point2.Z;
        }

        /// <summary>
        ///     Перегрузка оператора сравнения "больше или равно"
        /// </summary>
        /// <param name="point1">Левый элемент сравнения</param>
        /// <param name="point2">Правый элемент сравнения</param>
        /// <returns>
        ///     Если все координаты первой точки больше или равны координатам второй, возвращается true, в любом другом случае
        ///     - false
        /// </returns>
        public static bool operator >=(Point3D point1, Point3D point2)
        {
            return point1.X >= point2.X && point1.Y >= point2.Y && point1.Z >= point2.Z;
        }

        /// <summary>
        ///     Перегрузка метода Equals для объекта
        /// </summary>
        /// <param name="obj">Объект с которым производится сравнение текущего объекта</param>
        /// <returns>
        ///     Возвращает false если объект равен null. В случае если объект хранит ту же ссылку, то вернет true. В других
        ///     случаях производится сравнение типов и выполняется метод Equals для текущего и передаваемого объектов. Если типы
        ///     равны и Equals вернет true, то метод вернет true, в любом другом случае - false
        /// </returns>
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
        /// <returns>Хэш-код объекта</returns>
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
        /// <param name="point1">Левый элемент сравнения</param>
        /// <param name="point2">Правый элемент сравнения</param>
        /// <returns>Если все координаты обеих точек равны, возвращает true, в любом другом случае - false</returns>
        public static bool operator ==(Point3D point1, Point3D point2)
        {
            return Equals(point1, point2);
        }

        /// <summary>
        ///     Перегрузка оператора сравнения "не равно"
        /// </summary>
        /// <param name="point1">Левый элемент сравнения</param>
        /// <param name="point2">Правый элемент сравнения</param>
        /// <returns>Если все координаты обеих точек равны, возвращает false, в любом другом случае - true</returns>
        public static bool operator !=(Point3D point1, Point3D point2)
        {
            return !Equals(point1, point2);
        }

        #endregion
    }
}