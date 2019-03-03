using System;

namespace WinterTask
{
    /// <summary>
    ///     Класс который хранит квадратную матрицу 10x10 IComparable объектов
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PrivateDoubleArray<T> where T : IComparable
    {
        private const byte _arrayCapacity = 100;

        //Хранимый массив объектов
        private T[] DoubleArray { get; } = new T[_arrayCapacity];

        public PrivateDoubleArray(T[] doubleArray)
        {
            Array.Clear(DoubleArray, 0, doubleArray.Length);

            for (var i = 0; i < doubleArray.Length && i < _arrayCapacity; i++)
            {
                DoubleArray[i] = doubleArray[i];
            }
        }

        public T this[int i, int j]
        {
            get
            {
                IndexCorrectException(i, j);
                return DoubleArray[(int) Math.Sqrt(_arrayCapacity) * i + j];
            }
            set
            {
                IndexCorrectException(i, j);
                DoubleArray[(int) Math.Sqrt(_arrayCapacity) * i + j] = value;
            }
        }

        private static void IndexCorrectException(int i, int j)
        {
            if (i > (int) Math.Sqrt(_arrayCapacity) - 1 ||
                j > (int) Math.Sqrt(_arrayCapacity) - 1 || i < 0 && j < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}