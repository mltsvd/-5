using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibMas;
using ClassLib;
using System.IO;
using Microsoft.Win32;

namespace Пр5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        char[] mas;
        private void Cret_Click(object sender, RoutedEventArgs e)
        {

            Class2.CreateArray(out mas);//используем функцию для создания массива
            dg1.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            dg2.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            dg3.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            dg4.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            dg5.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }
            private void initi_Click(object sender, RoutedEventArgs e)
        {
            
            Class2.InitArray(out mas);//используем функцию
            dg1.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            Class2.InitArray(out mas);//используем функцию
            dg2.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            Class2.InitArray(out mas);//используем функцию
            dg3.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            Class2.InitArray(out mas);//используем функцию
            dg4.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            Class2.InitArray(out mas);//используем функцию
            dg5.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void ClerM_Click(object sender, RoutedEventArgs e)
        {
            Class2.CleanArray(ref mas);//используем функцию для очистки массива
            dg1.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            dg2.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            dg3.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            dg4.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            dg5.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void ClerL_Click(object sender, RoutedEventArgs e)
        {
            lsmr.Items.Clear();
        }

        private void Inf_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ShutDownProgS_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Rasch_Click(object sender, RoutedEventArgs e)
        {
            string rez = null;
            Class1.Raschet(mas, out rez);
            if(rez=="чередуются") rez+="1 массив";
            Class1.Raschet(mas, out rez);
            if (rez == "чередуются") rez += "2 массив";
            Class1.Raschet(mas, out rez);
            if (rez == "чередуются") rez += "3 массив";
            Class1.Raschet(mas, out rez);
            if (rez == "чередуются") rez += "4 массив";
            Class1.Raschet(mas, out rez);
            if (rez == "чередуются") rez += "5 массив";
            MessageBox.Show(rez);
        }
    }
}
