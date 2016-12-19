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
using System.Globalization;

namespace WpfApplication14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Osoba osoba ;
        
        public MainWindow()
        {
            InitializeComponent();
            osoba = new Osoba();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime data2;
                data2 = DateTime.ParseExact(DataUr.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                osoba.Ustaw(Imie.Text, Nazwisko.Text, data2);
                Opis.Text = osoba.ToString();
            }
            catch
            {
                MessageBox.Show("cos jest zle");
            }
        }
    }
}
