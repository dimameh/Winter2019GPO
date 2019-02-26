using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterTask
{//TODO: RSDN
    class Program
    {//TODO: RSDN
        static void Main(string[] args)
        {
			//TODO: RSDN
            Console.WriteLine("stringList demo-------------");
            StringList stringList = new StringList(new List<string> { "Asdfg", "Qwerty", "Qxcvb" });

            Console.WriteLine(stringList['Q']);

            Console.WriteLine();
            Console.WriteLine("PrivateTenInt demo-------------");
			//TODO: RSDN
            PrivateTenInt<int> intList = new PrivateTenInt<int>(new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            Console.WriteLine(intList[-5]);
            Console.WriteLine(intList[-4]);

            Console.WriteLine();
            Console.WriteLine("PrivateDoubleArray demo-------------");
            double[] doubleArray = new double[100];
            for (int i = 0; i < 100; i++)
            {
                doubleArray[i] = i;
            }
            PrivateDoubleArray<double> privateDoubleArray = new PrivateDoubleArray<double>(doubleArray);

            Console.WriteLine(privateDoubleArray[0, 0]);
            Console.WriteLine(privateDoubleArray[1, 5]);
			//TODO: Дубли вывода меню - посокращать!
            Console.WriteLine();
            Console.WriteLine("-------------LINQ-------------");

            Console.WriteLine("15 Integers demo-------------");
            List<int> integers = new List<int> { 1, 2, 51, 4, 5, 52, 7, 53, 9, 54, 11, 12, 55 };
			//TODO: RSDN
            var result1 =
				//TODO: Скобки писать не обязательно
                (
                from ints in integers
                where ints > 50
                select ints
                );
            PrintList(result1);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("even integers-------------");

            int result2 =
                (
                from ints in integers
                where ints % 2 == 0
                select ints
                ).Count();
            Console.WriteLine(result2);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("integers to double-------------");
            IEnumerable<double> doubles =
               (
               from ints in integers
               select (double)ints
               );
            PrintList(doubles);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Positive numbers-------------");
            var result3 =
              (
              from ints in integers
              where ints > 0
              select ints * 2 * 3.14//TODO: Math.PI - не?
              );
            PrintList(result3);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dictionary-------------");
            Dictionary<int, bool> isEven =
              (
              from ints in integers
              select ints
              ).ToDictionary(ints => ints, ints => ints % 2 == 0);
			//TODO: RSDN
            foreach (var v in isEven)
            {
                Console.WriteLine(v.Key.ToString() + ' ' + v.Value);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Contacts-------------");
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

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("A names-------------");
            IEnumerable<Contact> aNames = from contact in contacts
											//TODO: Если не окажется первого символа в строке?
                                          where contact.Name[0] == 'А'
                                          select contact;

            PrintList(aNames);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("89123456789-------------");

            Console.WriteLine((from contact in contacts
                               where contact.PhoneNumber == 89123456789
                               select contact).Single());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Order by Sex-------------");

            IEnumerable<Contact> sexGroups = from contact in contacts
                                          orderby contact.Sex 
                                          select contact;
            PrintList(sexGroups);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dictionary<string, Sex>-------------");
            Dictionary<string, Sex> sexDictionary = (from contact in contacts
                                                     select contact
					//TODO: RSDN
                                                    ).ToDictionary(contact => contact.ToString(), contact => contact.Sex);
			//TODO: Дубли
	        //TODO: RSDN
	        foreach (var v in sexDictionary)
            {
                Console.WriteLine(v.Key.ToString() + " - " + v.Value);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dictionary<string, Contact>-------------");
            Dictionary<string, Contact> nameDictionary = (from contact in contacts
                                                          select contact
					//TODO: RSDN
                                                    ).ToDictionary(contact => contact.Name, contact => contact);
			//TODO: RSDN
	        foreach (var v in nameDictionary)
            {
                Console.WriteLine(v.Key.ToString() + " - " + v.Value);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Сумирование номеров с двойным именем-------------");


            Console.WriteLine((from contact in contacts
                               where contact.Name.Contains("-")
                               select contact).Sum(contact => contact.PhoneNumber));
            Console.Read();
        }
        
        public static void PrintList<T>(IEnumerable<T> list)
        {
            foreach(var element in list)
            {
                Console.Write(element.ToString() + ", ");
            }
        }
    }
}
