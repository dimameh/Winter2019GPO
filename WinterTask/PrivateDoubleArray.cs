using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTask
{//TODO: RSDN
    /// <summary>
    /// Класс который хранит квадратную матрицу 10x10 IComparable объектов
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class PrivateDoubleArray<T> where T : IComparable
    {//TODO: RSDN
        const byte arrayCapacity = 100;

		//Хранимый массив объектов
        private T[] DoubleArray { get; set; } = new T[arrayCapacity];

        public PrivateDoubleArray(T[] doubleArray)
        {
            Array.Clear(DoubleArray, 0, doubleArray.Length);

            for (int i = 0; i < doubleArray.Length && i < arrayCapacity; i++)
            {
                DoubleArray[i] = doubleArray[i];
            }
        }

        public T this[int i, int j]
        {
            get
            { 
                IndexCorrectException(i, j);
                return DoubleArray[(int)Math.Sqrt(arrayCapacity)*i+j];
            }
            set
            {
                IndexCorrectException(i, j);
                DoubleArray[(int)Math.Sqrt(arrayCapacity) * i + j] = value;
            }
        }
        
        private void IndexCorrectException(int i, int j)
        {//TODO: RSDN
            if(i > (int)Math.Sqrt(arrayCapacity)-1 || j > (int)Math.Sqrt(arrayCapacity)-1 || i < 0 && j < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
