using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTask
{   /// <summary>
    /// Класс запускающий демонстрацию работы созданных классов
    /// </summary>
    class WinterTask
    {
        static void WriteTitle(string title)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(title + "-------------");
        }

        //Точка входа
        static void Main(string[] args)
        {
            WriteTitle("stringList demo");
            PrivateStringList stringList = new PrivateStringList(new List<string> { "Asdfg", "Qwerty", "Qxcvb" });

            Console.WriteLine(stringList['Q']);

            WriteTitle("PrivateTenInt demo");
            PrivateTenInt<int> intList = new PrivateTenInt<int>(new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            Console.WriteLine(intList[-5]);
            Console.WriteLine(intList[-4]);

            WriteTitle("PrivateDoubleArray demo");
            double[] doubleArray = new double[100];
            for (int i = 0; i < 100; i++)
            {

                doubleArray[i] = i;
            }
            PrivateDoubleArray<double> privateDoubleArray = new PrivateDoubleArray<double>(doubleArray);

            Console.WriteLine(privateDoubleArray[0, 0]);
            Console.WriteLine(privateDoubleArray[1, 5]);


            WriteTitle("-------------LINQ");

            WriteTitle("15 Integers demo");
            List<int> integers = new List<int> { 1, 2, 51, 4, 5, 52, 7, 53, 9, 54, 11, 12, 55 };
            var result15Ints = from ints in integers
                               where ints > 50
                               select ints;

            PrintList(result15Ints);

            WriteTitle("Even integers");

            int result2 =
                (
                from ints in integers
                where ints % 2 == 0
                select ints
                ).Count();
            Console.WriteLine(result2);

            WriteTitle("Integers to double");
            IEnumerable<double> doubles =
               from ints in integers
               select (double)ints;
            PrintList(doubles);

            WriteTitle("Positive numbers");
            var result3 =
              from ints in integers
              where ints > 0
              select ints * 2 * Math.PI;

            PrintList(result3);

            WriteTitle("Dictionary");
            Dictionary<int, bool> isEvenDictionary =
              (
              from ints in integers
              select ints
              ).ToDictionary(ints => ints, ints => ints % 2 == 0);

            PrintDictionary(isEvenDictionary);

            WriteTitle("Contacts");
            List<Contact> contacts = new List<Contact> {
                new Contact { Name = "Димас", PhoneNumber = 111111, Sex = Sex.Male },
                new Contact { Name = "Саша", PhoneNumber = 222222, Sex = Sex.Male },
                new Contact { Name = "Паша", PhoneNumber = 333333, Sex = Sex.Male },
                new Contact { Name = "Даша", PhoneNumber = 444444, Sex = Sex.Female },
                new Contact { Name = "Маша-Кваша", PhoneNumber = 555555, Sex = Sex.Female },
                new Contact { Name = "Анюша-Хрюша", PhoneNumber = 666666, Sex = Sex.Female },
                new Contact { Name = "Наташа", PhoneNumber = 7777777, Sex = Sex.Female },
                new Contact { Name = "Клаша", PhoneNumber = 888888, Sex = Sex.Female },
                new Contact { Name = "Ариша", PhoneNumber = 999999, Sex = Sex.Female },
                new Contact { Name = "Димас2", PhoneNumber = 89123456789, Sex = Sex.Male }
            };

            IEnumerable<string> names = from contact in contacts
                                        select contact.Name;

            PrintList(names);

            WriteTitle("A names");
            IEnumerable<Contact> aNames = from contact in contacts
                                          where contact.Name[0] == 'А' //Если не найдет, соответственно, ничего не выведет далее
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
            Dictionary<string, Sex> sexDictionary = (from contact in contacts
                                                     select contact
                                                    ).ToDictionary(contact => contact.ToString(), contact => contact.Sex);
            PrintDictionary(sexDictionary);

            WriteTitle("Dictionary<string, Contact>");
            Dictionary<string, Contact> nameDictionary = (from contact in contacts
                                                          select contact
                                                            ).ToDictionary(contact => contact.Name, contact => contact);
            PrintDictionary(nameDictionary);

            WriteTitle("Сумирование номеров с двойным именем");


            Console.WriteLine((from contact in contacts
                               where contact.Name.Contains("-")
                               select contact).Sum(contact => contact.PhoneNumber));
            Console.Read();
        }

        public static void PrintDictionary<V, K>(Dictionary<V, K> dictionary)
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine(element.Key.ToString() + " - " + element.Value);
            }
        }


        public static void PrintList<T>(IEnumerable<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException();
            }
            foreach (var element in list)
            {
                Console.Write(element.ToString() + ", ");
            }
        }
    }
}
