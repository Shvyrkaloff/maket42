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

namespace maket42
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Товар 1\nТовар 2\nТовар 3\nТовар 4\n");
        }

        private void hover1(object sender, MouseEventArgs e)
        {
            Change.Text = "Товары";
        }

        private void hover2(object sender, MouseEventArgs e)
        {
            Change.Text = "Об аптеке";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Лучшая аптека в городе");
        }

        private void hover3(object sender, MouseEventArgs e)
        {
            Change.Text = "Медицинские статьи";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Статья 1\nСтатья 2\nСтатья 3\nСтатья 4\n");
        }

        private void hover4(object sender, MouseEventArgs e)
        {
            Change.Text = "Как нас найти?";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            grid1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(238, 238, 238));
            border1.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border2.BorderBrush = new SolidColorBrush(Colors.Black);
            border3.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border4.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border5.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            border2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            border3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            border4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            text1.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            tool.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            b1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            b2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            b3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            b4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            status.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            border6.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border7.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border8.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
        }

        private void hover5(object sender, MouseEventArgs e)
        {
            Change.Text = "Светлая тема";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            LinearGradientBrush myVerticalGradient =
   new LinearGradientBrush();
            myVerticalGradient.StartPoint = new Point(0.5, 0);
            myVerticalGradient.EndPoint = new Point(0.5, 1);
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.Red, 0.0));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.Orange, 0.20));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.Yellow, 0.40));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.LimeGreen, 0.60));
            myVerticalGradient.GradientStops.Add(
                new GradientStop(Colors.DeepSkyBlue, 0.80));
            myVerticalGradient.GradientStops.Add(
               new GradientStop(Colors.Purple, 1));
            grid1.Background = myVerticalGradient;
            border1.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border2.BorderBrush = new SolidColorBrush(Colors.Black);
            border3.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border4.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border5.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            border2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            border3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            border4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            text1.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            text1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            tool.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            b1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            b2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            b3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            b4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            status.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            border5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
        }

        private void hover6(object sender, MouseEventArgs e)
        {
            Change.Text = "Градиент";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Мы распологаемся по адресу: Большая красная 55");
        }
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                var slider = sender as Slider;
                double value = slider.Value;
                text1.FontSize = value * 3;
            }
            catch
            {
            }
        }
    }
}

