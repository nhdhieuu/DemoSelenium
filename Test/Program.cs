using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Chrome;
using Timer = System.Timers.Timer;

namespace Test
{
    internal class Program
    {
        public static List<string> getRandomImagePathList(List<string> _filenamepath)
        {
            Random random = new Random();
            int listCount = random.Next(1, _filenamepath.Count);
            List<string> temp = new List<string>();

            for (int i = 0; i < listCount; i++)
            {
                int index = random.Next(0, _filenamepath.Count);
                temp.Add(_filenamepath[index]);
            }

            return temp;
        }

        private static List<DateTime> convertDateTimes(List<string> _dateTimes)
        {
            List<DateTime> temp = new List<DateTime>();
            foreach (var VARIABLE in _dateTimes)
            {
                temp.Add(DateTime.Parse(VARIABLE));
            }

            return temp;
        }
        private static void TimerCallback(Object o)  
        {
            Console.WriteLine("Hello World");
        }
        public static void Main(string[] args)
        {
            //Tim vào thời điểm: 12/12/2020 12:12:12;
            //Comment ngẫu nhiên vào thời điểm: 12/12/2020 12:12:12;
            //Đăng bài ngẫu nhiên vào thời điểm: 12/12/2020 12:12:12;
            
            string s = "Đăng bài ngẫu nhiên vào thời điểm: 2023-12-15 21:57:19";
            
            string a = s.Substring(s.Length- 19);
            DateTime dateTime = DateTime.Parse(a);

            TimeSpan temp =  TimeSpan.FromSeconds(DateTime.Now.Subtract(dateTime).TotalSeconds);
            
            
            
            if(DateTime.Now>dateTime)
                Console.WriteLine("Đã qua");
            else
                Console.WriteLine("Chưa qua");
            
 
        }
    }
}