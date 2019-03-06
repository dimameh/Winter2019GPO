using System;

namespace WinterTask
{
    /// <summary>
    ///     Класс который хранит квадратную матрицу 10x10 IComparable объектов
    /// </summary>
    /// <typeparam name="T">Тип массива хранимых объектов, который должен быть IComparable</typeparam>
    public class PrivateDoubleArray<T> where T : IComparable
    {
        #region Constants

        /// <summary>
        ///     Размер массива
        /// </summary>
        private const byte _arrayCapacity = 100;

        #endregion

        #region Properties

        /// <summary>
        ///     Массив хранимых объектов
        /// </summary>
        private T[] DoubleArray { get; } = new T[_arrayCapacity];

        #endregion

        #region Constructor

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="array">Массив объектов который будет храниться в объекте</param>
        public PrivateDoubleArray(T[] array)
        {
            Array.Clear(DoubleArray, 0, array.Length);

            for (var i = 0; i < array.Length && i < _arrayCapacity; i++)
            {
                DoubleArray[i] = array[i];
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Проверка входящих индексов на корректность.
        ///     Выбрасывает ошибку в случае некорректных входных параметров (индексов)
        /// </summary>
        /// <param name="i">первый индекс</param>
        /// <param name="j">второй индекс</param>
        private static void IndexCorrectException(int i, int j)
        {
            if (i > (int) Math.Sqrt(_arrayCapacity) - 1 ||
                j > (int) Math.Sqrt(_arrayCapacity) - 1 || i < 0 && j < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        /// <summary>
        ///     Возвращает элемент исходя из передаваемых индексов
        /// </summary>
        /// <param name="i">Первый индекс</param>
        /// <param name="j">Второй индекс</param>
        /// <returns>Элемент массива исходя из двух входящих индексов - i и j</returns>
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
    }
}