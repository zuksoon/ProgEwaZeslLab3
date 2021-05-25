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

namespace WinFormsAppLaboratoriaProg3_zad1
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

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float suma = float.Parse(Textbox1.Text) + float.Parse(TextBox2.Text);
                TextBoxWynik.Text = "Suma " + Textbox1.Text.ToString() + " + " + TextBox2.Text.ToString() + " = " + suma.ToString(); 
            }
            catch (Exception)
            {
                MessageBox.Show("nie prowadzono poprawych liczb !");
            }
        }

        private void btnRoznica_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float suma = float.Parse(Textbox1.Text) - float.Parse(TextBox2.Text);
                TextBoxWynik.Text = "Różnica " + Textbox1.Text.ToString() + " - " + TextBox2.Text.ToString() + " = " + suma.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie prowadzono poprawych liczb !");
            }
        }

        private void btnIloczyn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float suma = float.Parse(Textbox1.Text) * float.Parse(TextBox2.Text);
                TextBoxWynik.Text = "Iloczyn " + Textbox1.Text.ToString() + " * " + TextBox2.Text.ToString() + " = " + suma.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie prowadzono poprawych liczb !");
            }
        }

        private void btnIloraz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float suma = float.Parse(Textbox1.Text) / float.Parse(TextBox2.Text);
                TextBoxWynik.Text = "Iloraz" + Textbox1.Text.ToString() + " / " + TextBox2.Text.ToString() + " = " + suma.ToString();
            }
            catch (DivideByZeroException)   // trochę śmiesznie bo ignoruje on zupełnie fakt że podzielił przez zero i odpowiada jak gdyby nigdy nic wynikiem nieskończoności 
            {
                MessageBox.Show("Przez zero nie dzielimy !");
            }
            catch (Exception)
            {
                MessageBox.Show("Nie prowadzono poprawych liczb !");
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TekstBoxWynik_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxWynik_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
