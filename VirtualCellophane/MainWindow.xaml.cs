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

namespace VirtualCellophane
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Boolean isVisible = false;
        public MainWindow()
        {
            InitializeComponent();
            if (isVisible == false)
            {
                slider_ColorA.Visibility = Visibility.Hidden;
                slider_ColorR.Visibility = Visibility.Hidden;
                slider_ColorG.Visibility = Visibility.Hidden;
                slider_ColorB.Visibility = Visibility.Hidden;
            }
            slider_ColorA.Value = 255;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromArgb((byte)slider_ColorA.Value, (byte)slider_ColorR.Value, (byte)slider_ColorG.Value, (byte)slider_ColorB.Value);
            this.Background = new SolidColorBrush(color);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isVisible == true)
            {
                slider_ColorA.Visibility = Visibility.Hidden;
                slider_ColorR.Visibility = Visibility.Hidden;
                slider_ColorG.Visibility = Visibility.Hidden;
                slider_ColorB.Visibility = Visibility.Hidden;
                
            }
            else {
                slider_ColorA.Visibility = Visibility.Visible;
                slider_ColorR.Visibility = Visibility.Visible;
                slider_ColorG.Visibility = Visibility.Visible;
                slider_ColorB.Visibility = Visibility.Visible;
            }
            isVisible = !isVisible;
        }
    }
}
