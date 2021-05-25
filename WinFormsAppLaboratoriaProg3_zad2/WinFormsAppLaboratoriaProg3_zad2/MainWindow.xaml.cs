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

namespace WinFormsAppLaboratoriaProg3_zad2
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnOgnia_Click(object sender, RoutedEventArgs e)
        {
            if(ListBox1.SelectedIndex < 0 && ListBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Kapitanie, ale jaki CeL i która Torpeda?!");
            }
            else
            {
                if (btnUzbrojona.IsChecked == true && btnUzbrojona.IsChecked == true)
                {
                    MessageBox.Show("Wystrzelono " + ListBox2.SelectedItem.ToString() + " w stronę okrętu " + ListBox1.SelectedItem.ToString());
                    ListBox2.Items.RemoveAt(ListBox2.SelectedIndex);
                    Task.Delay(1000);
                    if (ListBox2.SelectedIndex == 1)
                    {
                        MessageBox.Show("Kapitanie, list z dowództwa. Niniejszym odsowam Pana ze stanowiska Kapitana. Niech się Pan modli by dotrzeć na ląd cało ! *!^@!");
                        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
                    }
                    else
                    {
                        TextBox1.Text = ("Zniszczyliśmy okręt " + ListBox1.SelectedItem.ToString());
                        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Kapitanie, ale Torpeda nie jest gotowa do strzału!");
                }
            }
        }
    }
}
