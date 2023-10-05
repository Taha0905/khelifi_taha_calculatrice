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

namespace khelifi_taha_calculatrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

//déclaration des variables
        double N1 = 0;
        double N2 = 0;
        double resultat = 0;
        char operation = ' ';

//création de la fonction display
        public void display(string num)
        {
            if (TB_Resultat.Text == "0")
            {
                TB_Resultat.Text = num;
            }
            else
            {
                TB_Resultat.Text = TB_Resultat.Text + num;
            }
        }

//configuration des bouttons
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            display(button.Content.ToString()); 
        }
    }
}
