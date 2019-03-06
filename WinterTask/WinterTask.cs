using System;
using System.Collections.Generic;
using System.Linq;

namespace WinterTask
{
    /// <summary>
    ///     Класс запускающий демонстрацию работы созданных классов
    /// </summary>
    public static class WinterTask
    {
        #region Private methods

        /// <summary>
        ///     Вывод названия раздела
        /// </summary>
        /// <param name="title">Название раздела</param>
        private static void WriteTitle(string title)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(title + "-------------");
        }

        /// <summary>
        ///     Вывод словаря
        /// </summary>
        /// <typeparam name="V">Тип ключа словаря</typeparam>
        /// <typeparam name="K">Тип значения словаря</typeparam>
        /// <param name="dictionary">Словарь</param>
        private static void PrintDictionary<V, K>(Dictionary<V, K> dictionary)
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine(element.Key + " - " + element.Value);
            }
        }

        /// <summary>
        ///     Вывод списка
        /// </summary>
        /// <typeparam name="T">Тип хранимый в списке</typeparam>
        /// <param name="list">Список</param>
        private static void PrintList<T>(IEnumerable<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException();
            }

            foreach (var element in list)
            {
                Console.Write(element + ", ");
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        ///     Точка входа
        /// </summary>
        /// <param name="args">Аргументы, сообщаемые при запуске</param>
        public static void Main(string[] args)
        {
            #region Демонстрация класса PrivateStringList

            WriteTitle("stringList demo");

            //Список для демонстрации
            var stringList =
                new PrivateStringList(new List<string> {"Asdfg", "Qwerty", "Qxcvb"});

            Console.WriteLine(stringList['Q']);

            WriteTitle("PrivateTenInt demo");

            var intList =
                new PrivateTenInt<int>(new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9});

            Console.WriteLine(intList[-5]);
            Console.WriteLine(intList[-4]);

            #endregion

            #region Демонстрация класса PrivateDoubleArray

            WriteTitle("PrivateDoubleArray demo");
            var doubleArray = new double[100];
            for (var i = 0; i < 100; i++)
            {
                doubleArray[i] = i;
            }

            var privateDoubleArray = new PrivateDoubleArray<double>(doubleArray);

            Console.WriteLine(privateDoubleArray[0, 0]);
            Console.WriteLine(privateDoubleArray[1, 5]);

            #endregion

            #region Демонстрация работы с LINQ

            WriteTitle("-------------LINQ");

            WriteTitle("15 Integers demo");

            var integers = new List<int>
            {
                1,
                2,
                51,
                4,
                5,
                52,
                7,
                53,
                9,
                54,
                11,
                12,
                55
            };

            var result15Integers = from ints in integers
                where ints > 50
                select ints;

            PrintList(result15Integers);

            WriteTitle("Even integers");

            var result2 =
            (
                from ints in integers
                where ints % 2 == 0
                select ints
            ).Count();

            Console.WriteLine(result2);

            WriteTitle("Integers to double");
            var doubles =
                from ints in integers
                select (double) ints;

            PrintList(doubles);

            WriteTitle("Positive numbers");
            var result3 =
                from ints in integers
                where ints > 0
                select ints * 2 * Math.PI;

            PrintList(result3);

            WriteTitle("Dictionary");
            var isEvenDictionary =
            (
                from ints in integers
                select ints
            ).ToDictionary(ints => ints, ints => ints % 2 == 0);

            PrintDictionary(isEvenDictionary);

            WriteTitle("Contacts");
            var contacts = new List<Contact>
            {
                new Contact {Name = "Димас", PhoneNumber = 111111, Sex = Sex.Male},
                new Contact {Name = "Саша", PhoneNumber = 222222, Sex = Sex.Male},
                new Contact {Name = "Паша", PhoneNumber = 333333, Sex = Sex.Male},
                new Contact {Name = "Даша", PhoneNumber = 444444, Sex = Sex.Female},
                new Contact
                {
                    Name = "Маша-Кваша", PhoneNumber = 555555, Sex = Sex.Female
                },
                new Contact
                {
                    Name = "Анюша-Хрюша", PhoneNumber = 666666, Sex = Sex.Female
                },
                new Contact
                {
                    Name = "Наташа", PhoneNumber = 7777777, Sex = Sex.Female
                },
                new Contact {Name = "Клаша", PhoneNumber = 888888, Sex = Sex.Female},
                new Contact {Name = "Ариша", PhoneNumber = 999999, Sex = Sex.Female},
                new Contact
                {
                    Name = "Димас2", PhoneNumber = 89123456789, Sex = Sex.Male
                }
            };

            var names = from contact in contacts
                select contact.Name;

            PrintList(names);

            WriteTitle("A names");

            //Если не найдет, соответственно, ничего не выведет далее
            var aNames = from contact in contacts
                where
                    contact.Name[0] == 'А'
                select contact;

            PrintList(aNames);

            WriteTitle("89123456789");

            Console.WriteLine((from contact in contacts
                where contact.PhoneNumber == 89123456789
                select contact).Single());

            WriteTitle("Order by Sex");

            IEnumerable<Contact> sexGroups = from contact in contacts
                orderby contact.Sex
                select contact;

            PrintList(sexGroups);

            WriteTitle("Dictionary<string, Sex>");
            var sexDictionary = (from contact in contacts
                    select contact
                ).ToDictionary(contact => contact.ToString(), contact => contact.Sex);

            PrintDictionary(sexDictionary);

            WriteTitle("Dictionary<string, Contact>");
            var nameDictionary = (from contact in contacts
                    select contact
                ).ToDictionary(contact => contact.Name, contact => contact);

            PrintDictionary(nameDictionary);

            WriteTitle("Сумирование номеров с двойным именем");


            Console.WriteLine((from contact in contacts
                where contact.Name.Contains("-")
                select contact).Sum(contact => contact.PhoneNumber));

            #endregion

            Console.Read();
        }

        #endregion
    }
}