using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna3._2
{
    class Program
    {
        static Dictionary<char, int> UnionDict(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
        {
            Dictionary<char, int> dict = dict1;
            char[] addedKeys = dict.Keys.ToArray();
            foreach (char key in dict2.Keys)
            {
                if (addedKeys.Contains(key))
                {
                    dict[key] += dict2[key];
                }
                else
                {
                    dict.Add(key, dict2[key]);
                }
            }
            return dict;
        }
        static void Main(string[] args)
        {
            
            Dictionary<char, int> dictionarySum1 = new Dictionary<char, int>()
            {
                {'a', 100 },
                {'b', 200 },
                {'c', 300 }      
            };
            Dictionary<char, int> dictionarySum2 = new Dictionary<char, int>()
            {
                {'a', 300 },
                {'b', 200 },
                {'d', 400 }
            };

            Dictionary<char, int> dictionarySum = UnionDict(dictionarySum2, dictionarySum1);


            foreach (char key in dictionarySum.Keys)
            {
                Console.WriteLine($"key: {key}  value: {dictionarySum[key]}");
            }
            Console.ReadLine();

            
        }
    }
}
