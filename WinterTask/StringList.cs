using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTask
{
    class StringList
    {
        private List<string> stringList;

        public StringList(List<string> stringList)
        {
            this.stringList = stringList;
        }

        public string this [char ch]
        {
            get
            {
                return stringList[GetIndexByFirstChar(ch)];
            }
            set
            {
                stringList[GetIndexByFirstChar(ch)] = value;
            }
        }

        private int GetIndexByFirstChar(char ch)
        {
            for (int i = 0; i < stringList.Capacity; i++)
            {
                if(stringList[i][0] == ch)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
