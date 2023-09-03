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

namespace DigitaalWoordenboek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string definitie = "divination by dreams";
        string woord = "oneiromancy";
        Dictionary<string, string> woordenMetDefinitie = new Dictionary<string, string>();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ButtonVoegWoord_Click(object sender, RoutedEventArgs e)
        {
            DataInputLoad(ControleLegeTxtBox());
    
        }

        private void DataInputLoad(bool ControleLegeTxtBox)
        {
            if(ControleLegeTxtBox == true)
            {
                definitie = tbxInputDefinitie.Text;

                woord = tbxInputWoord.Text;

                ListBoxItem item = new ListBoxItem();

                item.Content = woord;

                listbxWoorden.Items.Add(item);

                woordenMetDefinitie.Add(woord, definitie);

                tbxInputDefinitie.Text = " ";
                tbxInputWoord.Text =" ";

            }
        }

        private bool ControleLegeTxtBox()
        {
            string txbDefinitie = tbxInputDefinitie.Text;
            string txbWoord = tbxInputWoord.Text;

            if (string.IsNullOrWhiteSpace(txbWoord))
            {
                tbxInputWoord.Background = Brushes.Red;
                return false;
            }
            if(string.IsNullOrWhiteSpace(txbDefinitie))
            {
                tbxInputDefinitie.Background = Brushes.Red;
                return false;
            }
            else return true;
           
        }

        private void tbxInputWoord_MouseEnter(object sender, MouseEventArgs e)
        {
            tbxInputWoord.Background = Brushes.Transparent;
        }

        private void listbxWoorden_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //tbxDefinitie.Text = woordenMetDefinitie[woord];
            ListBoxItem item = (ListBoxItem)listbxWoorden.SelectedItem;
            tbxDefinitie.Text = woordenMetDefinitie[item.Content.ToString()];
        }

        private void tbxInputDefinitie_MouseEnter(object sender, MouseEventArgs e)
        {
            tbxInputDefinitie.Background = Brushes.White;
        }
    }
}
