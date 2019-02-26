using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTask
{
	//TODO: RSDN
    class PrivateTenInt<T> where T : IComparable
    {
		//TODO: Во-первых часто дублируется 10, во-вторых часто дублируется 5.
		//TODO: Всё повыносить и убрать дублирование
		//TODO: RSDN
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
				//TODO: Дублируется ниже.
                if (Math.Abs(index) > 5 || index == 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
				//TODO: RSDN
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
