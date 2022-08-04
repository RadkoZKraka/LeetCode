using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCalendar
{
    public class Test
    {
        public static void Main()
        {
            var cal = new MyCalendar();
            var check = cal.Book(10, 20);
            var check2 = cal.Book(20, 25);
            Console.WriteLine(check == check2);
        }
    }

    public class MyCalendar
    {
        List<int> _list = new List<int>();

        public MyCalendar()
        {
        }

        public bool Book(int start, int end)
        {
            var range = new List<int>();
            var temp = _list;
            range.AddRange(Enumerable.Range(start , end - start));
            temp.AddRange(Enumerable.Range(start, end - start));

            if (temp.Intersect(range).Any()) return false;

            _list.AddRange(Enumerable.Range(start, end - start));
            return true;
        }
    }
}