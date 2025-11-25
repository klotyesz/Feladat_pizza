using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Feladat_pizza
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string pizzateszta = "";
        string pizzaMeret = "";
        bool szallitas = false;
        List<string> valasztott_feltet = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lb_pizzateszta_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lb_pizzateszta.SelectedItem is ListBoxItem item)
            {
                pizzateszta = item.Content.ToString();
            }
        }

        private void combobox_meret_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lb_pizzateszta.SelectedItem is ComboBoxItem item)
            {
                pizzaMeret = item.Content.ToString();
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            valasztott_feltet.Clear();

            foreach (var elem in panel_feltet.Children)
            {
                if (elem is CheckBox cb && cb.IsChecked == true)
                {
                    valasztott_feltet.Add(cb.Content.ToString());
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (rb_atvetel.IsChecked == true)
            {
                szallitas = false;
            }
            else if (rb_szallitas.IsChecked == true)
            {
                szallitas = true;
            }
        }

        private void btn_rendeles_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Rendelése:\n\nPizzatesztá: {pizzateszta}\nPizza méret: {pizzaMeret}\nFeltétek: {string.Join(", ", valasztott_feltet)}\nÁtvételi mód: {(szallitas ? "Házhozszállítás":"Személyes átvétel")}");
        }
    }
}