using System;
using System.Collections.Generic;

namespace WinterTask
{
    /// <summary>
    ///     Содержит список строк, индексируемых по первому символу
    /// </summary>
    public class PrivateStringList
    {
        #region Properties

        /// <summary>
        ///     Список строк
        /// </summary>
        private List<string> StringList { get; }

        #endregion

        #region Constructor

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="stringList"></param>
        public PrivateStringList(List<string> stringList)
        {
            StringList = stringList;
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Получить индекс строки в списке по первому символу
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        private int GetIndexByFirstChar(char symbol)
        {
            for (var i = 0; i < StringList.Capacity; i++)
            {
                if (StringList[i][0] == symbol)
                {
                    return i;
                }
            }

            return -1;
        }

        #endregion

        /// <summary>
        ///     Оператор доступа к элементам массива по индексам
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[char symbol]
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
    }
}