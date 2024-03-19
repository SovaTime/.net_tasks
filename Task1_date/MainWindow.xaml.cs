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

namespace Task1_date
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

        private void CheckDate_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Day.Text) && !string.IsNullOrEmpty(Month.Text) && !string.IsNullOrEmpty(Year.Text))
            {
                int day = Convert.ToInt32(Day.Text);
                int month = Convert.ToInt32(Month.Text);
                int year = Convert.ToInt32(Year.Text);

                Date nowDay = new Date(day, month, year);
                if (nowDay.CheckDate())
                {
                    OutputBox.Text = "Дата введена корректно";
                }
                else
                {
                    OutputBox.Text = "Дата введена некорректно";
                }

            }
            else
            {
                OutputBox.Text = "Введите дату";
            }
        }

        private void DayInMonth_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Day.Text) && !string.IsNullOrEmpty(Month.Text) && !string.IsNullOrEmpty(Year.Text))
            {
                int day = Convert.ToInt32(Day.Text);
                int month = Convert.ToInt32(Month.Text);
                int year = Convert.ToInt32(Year.Text);

                Date nowDay = new Date(day, month, year);
                if (nowDay.CheckDate())
                {
                    string ext = Convert.ToString(nowDay.DaysInMonth());
                    OutputBox.Text = "Количество дней в месяце: " + ext;
                }
                else
                {
                    OutputBox.Text = "Введите корректную дату";
                }
                
            }
            else
            {
                OutputBox.Text = "Введите дату";
            }
        }

        private void PlusDate_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Day.Text) && !string.IsNullOrEmpty(Month.Text) && !string.IsNullOrEmpty(Year.Text))
            {
                int day = Convert.ToInt32(Day.Text);
                int month = Convert.ToInt32(Month.Text);
                int year = Convert.ToInt32(Year.Text);

                Date nowDay = new Date(day, month, year);
                if (nowDay.CheckDate())
                {
                    if (!string.IsNullOrEmpty(DayPlus.Text))
                    {
                        nowDay.AddDays(Convert.ToInt32(DayPlus.Text));
                    }
                    if (!string.IsNullOrEmpty(MonthPlus.Text))
                    {
                        nowDay.AddMonths(Convert.ToInt32(MonthPlus.Text));
                    }
                    if (!string.IsNullOrEmpty(YearPlus.Text))
                    {
                        nowDay.AddYears(Convert.ToInt32(YearPlus.Text));
                    }

                    string ext = Convert.ToString(nowDay.day) + ".";
                    if (nowDay.month < 10)
                    {
                        ext = ext + "0" + Convert.ToString(nowDay.month) + ".";
                    }
                    else
                    {
                        ext = ext + Convert.ToString(nowDay.month) + ".";
                    }
                    ext = ext + Convert.ToString(nowDay.year);
                    OutputBox.Text = ext;
                }
                else
                {
                    OutputBox.Text = "Введите корректную дату";
                }

            }
            else
            {
                OutputBox.Text = "Введите дату";
            }
        }

        private void OutputText_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
              
    }
}
