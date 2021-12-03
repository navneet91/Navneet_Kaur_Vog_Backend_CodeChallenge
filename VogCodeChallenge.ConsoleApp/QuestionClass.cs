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
        public static object TESTModule(dynamic val)
        {
            object result = null;
            switch (val)
            {
                case int _ when val >= 1 && val <= 4:
                    result=val * 2;
                    break;
                case int _ when val > 4:
                   result=val * 3;
                    break;
                case int _ when val < 1:
                    throw new Exception("Provided value is Negative");
                    break;
                case float _ when val == 1.0f || val == 2.0f:
                    result = 3.0f;
                    break;
                case string _:
                    result=val.ToString().ToUpper();
                    break;

                default:
                    result = val;
                    break;
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
