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
            rez = null;
            for (int i = 0; i < mas.Length-1; i++)
            {
                if ((char.IsLower(mas[i]) == true && char.IsUpper(mas[i + 1]) == true) || (char.IsUpper(mas[i]) == true && char.IsLower(mas[i + 1]) == true))
                {
                    kol++;
                }
            }
            if (kol == 50) rez = "чередуются";
            else rez = "нет";
        }
    }
}
