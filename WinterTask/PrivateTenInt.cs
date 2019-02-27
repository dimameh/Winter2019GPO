using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTask
{
	/// <summary>
    /// Класс хранящий массив, вмещающий 10 элементов, индексация которых начинается с -5 и заканчивается 5
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class PrivateTenInt<T> where T : IComparable
    {
        private const int Capacity = 10;
        private T[] IntArray { get; set; } = new T[Capacity];

        public PrivateTenInt(T[] array)
        {
            Array.Clear(IntArray, 0, IntArray.Length);
            if (array.Length <= Capacity) 
            {
                for (int i = 0; i < array.Length; i++)
                {
                    IntArray[i] = array[i];
                }
            }
            else
            {
                for (int i = 0; i < Capacity; i++)
                {
                    IntArray[i] = array[i];
                }
            }
        }

        public T this[int index]
        {
            get
            {
                IsIndexCorrect(index);
                return IntArray[Capacity / 2 + index];                
            }
            set
            {
                IsIndexCorrect(index);
                IntArray[Capacity / 2 + index] = value;
            }
        }

        private void IsIndexCorrect(int index)
        {
            if( Math.Abs(index) > Capacity / 2 || index == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
