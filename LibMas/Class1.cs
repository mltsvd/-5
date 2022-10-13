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
    {
        public static void InitArray(out char[] mas,int column)
        {
            Random Rnd; Rnd = new Random();
            mas = new char[column];
            for (int i = 0; i < mas.Length; i++)
                mas[i] = Convert.ToChar(Rnd.Next('A','z'));
        }
        public static void CreateArray(out char[] mas, int column)
        {
            mas = new char[column];
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