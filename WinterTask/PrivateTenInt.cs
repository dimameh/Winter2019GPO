using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTask
{
    class PrivateTenInt<T> where T : IComparable
    {
        private T[] intArray = new T[10];

        public PrivateTenInt(T[] array)
        {
            Array.Clear(intArray, 0, intArray.Length);
            if (array.Length <= 10) 
            {
                for (int i = 0; i < array.Length; i++)
                {
                    intArray[i] = array[i];
                }
            }
            else
            {
                for (int i = 0; i <10; i++)
                {
                    intArray[i] = array[i];
                }
            }
        }

        public T this[int index]
        {
            get
            {
                if (Math.Abs(index) > 5 || index == 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return intArray[5+index];                
            }
            set
            {
                if (Math.Abs(index) > 5 || index == 0)
                {
                    throw new ArgumentOutOfRangeException();                   
                }
                intArray[5 + index] = value;
            }
        }
    }
}
