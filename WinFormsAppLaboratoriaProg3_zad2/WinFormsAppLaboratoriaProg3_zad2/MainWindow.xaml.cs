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
        /*
        void PrintText(object sender, SelectionChangedEventArgs args)
{
    ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
    tb.Text = "   You selected " + lbi.Content.ToString() + ".";
}
        */
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
                    ListBoxItem ListItem1 = (ListBoxItem)ListBox1.SelectedItem; // tworzymy zbienną typu ListBox Item by dało się odczytać zawartość pola content
                    ListBoxItem ListItem2 = (ListBoxItem)ListBox2.SelectedItem;
                    
                    MessageBox.Show("Wystrzelono " + ListItem2.Content + " w stronę okrętu " + ListItem1.Content);
                    ListBox2.Items.RemoveAt(ListBox2.SelectedIndex);
                    Task.Delay(1000);
                    if ((string)ListItem1.Content == "Bismark")
                    {
                        
                        MessageBox.Show("Kapitanie, list z dowództwa. Niniejszym odsówam Pana ze stanowiska Kapitana. Niech się Pan modli by dotrzeć na ląd cało ! *!^@!");
                        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
                    }
                    else
                    {
                        TextBox1.Text = ("Zniszczyliśmy okręt " + ListItem1.Content);
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
