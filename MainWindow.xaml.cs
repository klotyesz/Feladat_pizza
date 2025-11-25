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
    }
}