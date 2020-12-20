using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Wyniki
    {
        private List<String> list;
   
      public  Wyniki(int x,int y)
        {
            int i = 1;
            list = new List<String>();
            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\results.txt");
            foreach (string line in lines)
            {
                list.Add(i+". "+line);
                i++;
            }

    }
        public List<String> getlist()
        {
            return list;
        }

    }
}
