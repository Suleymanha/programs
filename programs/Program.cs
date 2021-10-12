using System;
using System.Collections;
using System.Collections.Generic;

namespace programs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList programs = new SortedList();
            programs.Add(2000 ,"C#");
            programs.Add(1995,"JAVA" );
            programs.Add(1998,"php" );

            foreach(DictionaryEntry item in programs)
            {
                Console.WriteLine("{0}and{1}",item.Key,item.Value);

            }
            Console.WriteLine();
            
           
        }
    }
}
