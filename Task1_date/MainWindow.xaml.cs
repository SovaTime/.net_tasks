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

namespace Task1
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

        private int[] InputDate_Click(object sender, RoutedEventArgs e)
        {
            int dayNow = Convert.ToInt32(Day.Text);
            int monthNow = Convert.ToInt32(Month.Text);
            int yearNow = Convert.ToInt32(Year.Text);
            int weekDay = Convert.ToInt32(WeekDay.Text);
            int[] nowDate = {dayNow, monthNow, yearNow, weekDay};
            return nowDate;
        }
    }
}
