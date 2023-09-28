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
        int N1 = 0;        
        int N2 = 0;
        int resultat = 0;
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
        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            display("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            display("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            display("6");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            display("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            display("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            display("9");
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            display("0");
        }

        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_Resultat.Clear();
        }

        //boutton égale
        private void BTN_Egale_Click(object sender, RoutedEventArgs e)
        {
            if (operation == '+')
            {
                // Effectuez l'addition
                resultat = N1 + int.Parse(TB_Resultat.Text);
            }
            else if (operation == '-')
            {
                // Effectuez la soustraction
                resultat = N1 - int.Parse(TB_Resultat.Text);
            }

            
            else if (operation == '/')
            {
                int N2 = int.Parse(TB_Resultat.Text);

                // Vérifiez si le dénominateur est égal à zéro
                if (N2 == 0)
                {
                    TB_Resultat.Text = "Erreur : Division par zéro";
                    return; // Sortez de la méthode pour éviter une division par zéro
                }

                // Effectuez la division
                resultat = N1 / N2;
                    }
            else if (operation == '*')
            {
                // Effectuez la multiplication
                resultat = N1 * int.Parse(TB_Resultat.Text);
            }

            else if (operation == 'C') 
            {
                // Calculez le carré du nombre
                int nombre = int.Parse(TB_Resultat.Text);
                resultat = nombre * nombre;
            }
            // Affichez le résultat dans la zone de texte
            TB_Resultat.Text = resultat.ToString();

        }

        //boutton moins
        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {

            N1 = int.Parse(TB_Resultat.Text);

            TB_Resultat.Clear();

            operation = '-';
        }

        //boutton diviser
        private void BTN_Diviser_Click(object sender, RoutedEventArgs e)
        {
            N1 = int.Parse(TB_Resultat.Text);

            TB_Resultat.Clear();

            operation = '/';
        }

        //boutton plus
        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            N1 = int.Parse(TB_Resultat.Text);

            TB_Resultat.Clear();

            operation = '+';
        }

        //boutton fois
        private void BTN_Fois_Click(object sender, RoutedEventArgs e)
        {
            N1 = int.Parse(TB_Resultat.Text);

            TB_Resultat.Clear();

            operation = '*';
        }

        private void BTN_carré_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_Resultat.Text))
            {
                int nombre = int.Parse(TB_Resultat.Text);
                int carre = nombre * nombre;
                TB_Resultat.Text = carre.ToString();
            }
        }
    }
}
