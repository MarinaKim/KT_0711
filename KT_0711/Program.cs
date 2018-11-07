using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KT_0711
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex06();
        }
        static void Ex03()
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            Entity db = new Entity();
            var result = db.Table_Sales.ToList();//Ienumerable сразу идет загрузка данных toList,toArray,count,First

            foreach (var item in result)
            {
                Console.WriteLine(".");
            }

            foreach (var item in result)
            {
                Console.WriteLine(".");
            }


            var result1 = db.Table_Sales; //IQuery отложенный запрос

            foreach (var item in result1)//запрос в БД здесь
            {
                Console.WriteLine(".");
            }

            foreach (var item in result1)//опасность в том что, каждый раз обращется в БД
            {
                Console.WriteLine(".");
            }


            sw.Stop();

            Console.WriteLine("Elapsed:{0}", sw.Elapsed);
            //IQuery select *from....
            //IEnumerable конкретные записи, данные 

        }

        static void EX04()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int fact = 10;
            int res = 10;
            var query = numbers.Select(m => m * fact);

            var q2 = query.Where(w => w > res);
            foreach (var item in query)
            {
                Console.WriteLine(item+"|"); 
            }
        }

        //подзапрос
        static void EX05()
        {

            string[] names = { "jkfgh554h", "hjfgg", "kjdfhjg", "dkljgjh" };

            var q = names.OrderBy(o => o.Split().Last());

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            var q1 = names.Where(w => w.Length ==
                           names.OrderBy(o => o.Length)
                                .Select(s => s.Length)
                                .First());

            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            var q2 = from n in names
                     where n.Length ==
                     (from n2 in names
                      orderby n2.Length
                      select n2.Length).First()
                     select n;

        }

        //into только в синтаксисе облегченного восприятия
        static void Ex06()
        {
            string[] names = { "jkfgh554h", "hjfgg", "kjdfhjg", "dkljgjh" };
            var q1 = from n in names
                     select Regex.Replace(n, "[jk]", "")
                    into result
                     where result.Length > 5
                     select result;
            foreach (var item in q1)
            {
                Console.WriteLine(item);

            }

            // лямда-выражения

            var q2 = names.Select(s => Regex.Replace(s, "[jk]", ""))
                .Where(w => w.Length > 5);

            foreach (var item in q2)
            {
                Console.WriteLine(item);

            }
        }

        //оболочка
        static void Ex07()
        {
            string[] names = { "jkfgh554h", "hjfgg", "kjdfhjg", "dkljgjh" };
            var q1 = from n in names
                     select Regex.Replace(n, "[jk]", "")
                    into result
                     where result.Length > 5
                     select result;
            foreach (var item in q1)
            {
                Console.WriteLine(item);

            }

            // лямда-выражения

            var q2 = names.Select(s => Regex.Replace(s, "[jk]", ""))
                .Where(w => w.Length > 5);

            foreach (var item in q2)
            {
                Console.WriteLine(item);

            }

            //оболочка
            var q3 = names.Select(s => Regex.Replace(s, "[jk]", ""));
            var q4 = q3.Where(w => w.Length > 5);
        }
        //let только в синтаксисе облегченного восприятия
        static void Ex08()
        {
            string[] names = { "jkfgh554h", "hjfgg", "kjdfhjg", "dkljgjh" };

            var q = from n in names
                    let vol = Regex.Replace(n, "[jk]", "") //проецирует элемент вместе с существующим
                    where vol.Length > 5
                    select n;
        }
    }

    

}
