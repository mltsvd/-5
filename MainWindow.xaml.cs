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
            if (Int32.TryParse(Column.Text, out int column) == true)
            {
                Class2.CreateArray(out mas, column);
                dg1.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
                dg2.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
                dg3.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
                dg4.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
                dg5.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            }
            else
            {
                MessageBox.Show("Введите корректный размер массива ", "Ошибка", MessageBoxButton.OK,MessageBoxImage.Error);
            }
                
        }
            private void initi_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(Column.Text, out int column) == true)
            {
                Class2.InitArray(out mas, column);//используем функцию
                dg1.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
                Class2.InitArray(out mas, column);//используем функцию
                dg2.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
                Class2.InitArray(out mas, column);//используем функцию
                dg3.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
                Class2.InitArray(out mas, column);//используем функцию
                dg4.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
                Class2.InitArray(out mas, column);//используем функцию
                dg5.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            }
            else
            {
                MessageBox.Show("Введите корректный размер массива ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

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
            MessageBox.Show("Выполнили практическую работу №5 студенты:\nЛейбович М.В;\nМельцаева Д.М.\nДаны пять одномерных массива символьных (только латинские буквы) элементов. Размер каждого массива не превосходит 100 элементов. Для каждого из массивов определить, чередуются ли в нем буквы строчные и прописные. Если да, то указать порядковый номер такого массива, в противном случае вывести отрицательный ответ.Проверку массива на выполнение условия оформить в виде процедуры с передачей в нее всех элементов рассматриваемого массива.", "Информация о программе", MessageBoxButton.OK);
        }

        private void ShutDownProgS_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Rasch_Click(object sender, RoutedEventArgs e)
        {
            lsmr.Items.Clear();
            string rez = null;
            Class1.Raschet(mas, out rez);
            if (rez == "чередуются")
            {
                rez = "1 массив";
                lsmr.Items.Add(rez);
            }
            else
            {
                rez = "Не чередуются";
            }
                Class1.Raschet(mas, out rez);
            if (rez == "чередуются")
            {
                rez = "2 массив";
                lsmr.Items.Add(rez);
            }
            else
            {
                rez = "Не чередуются";
            }
            Class1.Raschet(mas, out rez);
            if (rez == "чередуются")
            {
                rez = "3 массив";
                lsmr.Items.Add(rez);
            }
            else
            {
                rez = "Не чередуются";
            }
            Class1.Raschet(mas, out rez);
            if (rez == "чередуются")
            {

                rez = "4 массив";
                lsmr.Items.Add(rez);
            }
            else
            {
                rez = "Не чередуются";
            }
            Class1.Raschet(mas, out rez);
            if (rez == "чередуются")
            {
                rez = "5 массив";
                lsmr.Items.Add(rez);
            }
            else
            {
                rez = "Не чередуются";
            }
            lsmr.Items.Add(rez);

        }
        private void dataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            int columnIndex = e.Column.DisplayIndex;
            mas[columnIndex] = Convert.ToChar(((TextBox)e.EditingElement).Text);
        }
    }
}
