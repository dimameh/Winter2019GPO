using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTask
{
	//TODO: RSDN
    class StringList
    {
		//TODO: RSDN
        private List<string> stringList;

        public StringList(List<string> stringList)
        {
            this.stringList = stringList;
        }

		//TODO: RSDN
        public string this [char ch]
        {
            get
            {
                return stringList[GetIndexByFirstChar(ch)];
            }
            set
            {
				//TODO: Упадёт при передаче несуществующего символа
                stringList[GetIndexByFirstChar(ch)] = value;
            }
        }

		//TODO: RSDN
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
