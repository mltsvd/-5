using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLib
{
    public class Class1
    {
        public static void Raschet(char[] mas, out string rez)
        {
            int kol = 0;
            string ch,ch1;
            rez = null;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                ch = mas[i].ToString();
                ch1 = mas[i+1].ToString();
                if (char.IsLower(mas[i]) == true && char.IsUpper(mas[i + 1]) == true)
                {
                    kol++;
                }
                if (char.IsUpper(mas[i]) == true && char.IsLower(mas[i + 1]) == true)
                {
                    kol++;
                } 
            }
            if (kol == mas.Length-1) rez = "чередуются";
            else rez = "Не чередуются";
        }
    }
}
