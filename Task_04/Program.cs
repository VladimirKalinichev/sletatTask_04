using System;
using System.Collections.Generic;
using System.Threading;

namespace Task_04
{

    /// Задача - дорабатываем будильник
    /// необходимо написать метод, который позволит считать, сколько времени осталось до того, как зазвонит будильник


    class Program
    {

       public static void Main(string[] args)
        {


            var wakeUp = DateTime.Now.AddMinutes(5);
            foreach (DateTime value in AlarmClockTimer(wakeUp))
            {
                
            }
        }
              /*Работает, но лучше погуглю как реализовать без костылей */     
        
        public static  IEnumerable<DateTime> AlarmClockTimer( DateTime wakeUp)
        {
           
           for (; ; )
            {
                Console.WriteLine((wakeUp - DateTime.Now).ToString(@"dd\.hh\:mm\:ss"));
                Thread.Sleep(1000);
            }

            throw new NotImplementedException();
        }
    }
}