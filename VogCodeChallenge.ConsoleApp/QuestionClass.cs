using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.ConsoleApp
{
  public  class QuestionClass
    {
        static List<string> NamesList = new List<string>()
                    {
                    "Jimmy",
                    "Jeffrey",
                    "John",
                    };


        public static void IterateName(int i)
        {
            if (i >= NamesList.Count)
            {
                return;
            }
            Console.WriteLine(NamesList[i]);
            IterateName(i + 1);
        }
    }
}
