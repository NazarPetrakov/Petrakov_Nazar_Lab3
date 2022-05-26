using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Laboratorna3
{
    class Program
    {
        static void Main(string[] args)
        {
            int rep = 0;

            JsonTextReader reader = new JsonTextReader(new StreamReader("engText.json"));
            JsonSerializer serializer = new JsonSerializer();

            string newstr = serializer.Deserialize<string>(reader);
           

            List<string> engText = newstr.Split(' ').ToList();

            for (int i = 0; i < engText.Count; i++)
            {
                rep = 0;
                for (int j = engText.Count - 1; j >= 0; j--)
                {
                    if (engText[j].Equals(engText[i]))
                    {
                        rep++;
                    }

                }
                
                if (rep == 1)
                {
                    engText[i] = string.Concat("'", engText[i], "'");
                }
            }   

            foreach (string item in engText)
            {              
                Console.Write( item + " ");
            }
            
           Console.ReadLine();
        }
    }
}
