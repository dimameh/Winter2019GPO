using System;

namespace WinterTask
{
    /// <summary>
    ///     Класс хранящий массив, вмещающий 10 элементов, индексация которых начинается с -5 и заканчивается 5
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PrivateTenInt<T> where T : IComparable
    {
        #region Constants

        private const int _capacity = 10;

        #endregion

        #region Properties

        private T[] IntArray { get; } = new T[_capacity];

        #endregion

        #region Constructor

        public PrivateTenInt(T[] array)
        {
            Array.Clear(IntArray, 0, IntArray.Length);
            if (array.Length <= _capacity)
            {
                for (var i = 0;
                    array.Length <= _capacity ? i < array.Length : i < _capacity;
                    i++)
                {
                    IntArray[i] = array[i];
                }
            }
        }

        #endregion

        #region Private methods

        private static void IsIndexCorrect(int index)
        {
            if (Math.Abs(index) > _capacity / 2 || index == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        public T this[int index]
        {
            get
            {
                IsIndexCorrect(index);
                return IntArray[_capacity / 2 + index];
            }
            set
            {
                IsIndexCorrect(index);
                IntArray[_capacity / 2 + index] = value;
            }
        }
    }
}