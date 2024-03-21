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

namespace Task2_animal
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

        Turtle turtle = new Turtle(3);
        Dog dog = new Dog(3);
        Panther panther = new Panther(3);

        private void MoveTurtle_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = turtle.Move();
        }

        private void StandTurtle_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = turtle.Stand();
        }

        private void MoveDog_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = dog.Move();
        }

        private void StandDog_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = dog.Stand();
        }

        private void VoiceDog_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = dog.Voice();
        }

        private void MovePanther_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = panther.Move();
        }

        private void StandPanther_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = panther.Stand();
        }

        private void VoicePanther_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = panther.Voice();
        }

        private void ClimbePanther_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = panther.Climb();
        }

        private void OutputBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
