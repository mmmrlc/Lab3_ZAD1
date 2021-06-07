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

namespace Lab3_ZAD1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                float x = float.Parse(textbox1.Text);
                float y = float.Parse(textbox2.Text);
            if (y == 0)
                textbox4.Text = "Nieprawidlowe dane";
            else
                textbox4.Text = "Iloraz " + (x).ToString() + " / " + (y).ToString() + " = " + (x / y).ToString();
            
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
                float x = float.Parse(textbox1.Text);
                float y = float.Parse(textbox2.Text);
                textbox4.Text = "Suma " + (x).ToString() + " + " + (y).ToString() + " = " + (x + y).ToString();
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
                float x = float.Parse(textbox1.Text);
                float y = float.Parse(textbox2.Text);
                textbox4.Text = "Roznica " + (x).ToString() + " - " + (y).ToString() + " = " + (x - y).ToString();
           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
                float x = float.Parse(textbox1.Text);
                float y = float.Parse(textbox2.Text);
                textbox4.Text = "Iloczyn " + (x).ToString() + " * " + (y).ToString() + " = " + (x * y).ToString();
            
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
