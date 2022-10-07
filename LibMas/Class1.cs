using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;


namespace LibMas
{
    public class Class2
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="mas"//массив ></param>
    /// <param name="column"// число колонок в массиве></param>
    /// <param name="randMax"// рандомизация></param>
        public static void InitArray(out char[] mas)
        {
            Random Rnd; Rnd = new Random();
            mas = new char[10];
            //mas = new String[100];
            for (int i = 0; i < mas.Length; i++)
                mas[i] = Convert.ToChar(Rnd.Next('A','z'));
        }
        public static void CreateArray(out char[] mas)
        {
            mas = new char[10];//создаем массив
        }
        
        public static void CleanArray(ref char[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = ' ';
            }
        }
    }
}