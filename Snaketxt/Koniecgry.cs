using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Snake
{
    
    class Koniecgry
    {

        int result;
        public Koniecgry(int res)
        {
            result = res;
        }
            public void dodawanie(String s)
            {
            String wynik;
            int pom1 = 0;
            int pom2 = 0;
            int i=0;
            int pom3= 0;
            wynik = s + ":  " + result.ToString();

            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\results.txt");
            List<String> linesfinal = new List<string>();
            foreach (string line in lines)
            {
                for (i = 0; i < line.Length; i++)
                {
                    if (line[i] == ' ' && line[i + 1] == ' ')
                    {
                        linesfinal.Add(line);
                        string sd = "";
                        for (int j = i + 2; j < line.Length; j++)
                        {
                            sd = sd + line[j];
                        }
                        int x = Int32.Parse(sd);
                        if (x < result)
                        {
                            pom3 = 1;
                            pom2= 1;
                            break;
                        }


                    }
                }
                if(pom2==0)
                pom1++;
            }

                if (pom3 == 1)
                {
                linesfinal.Clear();
                int jj = 0;
                foreach (string line in lines)
                {
                    if (jj == pom1)
                    {
                        linesfinal.Add(wynik);
                        jj++;
                    }
                    if(jj<10)
                        linesfinal.Add(line);
                    jj++;
                }
                }
                else if(pom1<10) {
                linesfinal.Add(wynik);

                }
            else{ }

            System.IO.File.WriteAllLines(@"..\..\..\results.txt", linesfinal);
        }


        

    }
}
