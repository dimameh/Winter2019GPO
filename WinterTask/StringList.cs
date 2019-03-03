using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTask
{
	/// <summary>
    /// Содержит список строк, индексируемых по первому символу
    /// </summary>
    public class PrivateStringList
    {
        private List<string> StringList { get; }

        public PrivateStringList(List<string> stringList)
        {
            StringList = stringList;
        }
        
        public string this [char symbol]
        {
            get => StringList[GetIndexByFirstChar(symbol)];
            set
            {
                if (GetIndexByFirstChar(symbol) == -1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                StringList[GetIndexByFirstChar(symbol)] = value;
            }
        }

        private int GetIndexByFirstChar(char symbol)
        {
            for (int i = 0; i < StringList.Capacity; i++)
            {
                if(StringList[i][0] == symbol)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
