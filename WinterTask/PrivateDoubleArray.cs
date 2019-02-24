using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTask
{
    class PrivateDoubleArray<T> where T : IComparable
    {
        private T[] doubleArray = new T[100];

        public PrivateDoubleArray(T[] doubleArray)
        {
            Array.Clear(this.doubleArray, 0, doubleArray.Length);

            if (doubleArray.Length <= 100)
            {
                for (int i = 0; i < doubleArray.Length; i++)
                {
                    this.doubleArray[i] = doubleArray[i];
                }
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    this.doubleArray[i] = doubleArray[i];
                }
            }
        }

        public T this[int i, int j]
        {
            get
            {
                if (i > 9 || j > 9 || i < 0 || j < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return doubleArray[10*i+j];
            }
            set
            {
                if (i > 9 || j > 9 || i < 0 || j < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                doubleArray[10 * i + j] = value;
            }
        }
    }
}
