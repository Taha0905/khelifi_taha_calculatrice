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

        // Déclaration des variables
        double N1 = 0;         
        double N2 = 0;       
        double resultat = 0; 
        char operation = ' ';  

        // Fonction pour afficher les chiffres et opérateurs sur l'écran
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

        // Gestionnaire d'événement lorsque l'utilisateur clique sur un chiffre
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            display(button.Content.ToString());
        }

        // Gestionnaire d'événement pour le bouton "C"
        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            N1 = 0;
            N2 = 0;
            resultat = 0;
            operation = ' ';
            TB_Resultat.Text = "0";
        }

        // Gestionnaire d'événement lorsque l'utilisateur clique sur un opérateur
        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            char newOperation = button.Content.ToString()[0];

            if (operation != ' ')
            {
                N2 = double.Parse(TB_Resultat.Text);
                if (operation == '+')
                {
                    resultat = N1 + N2;
                }
                else if (operation == '-')
                {
                    resultat = N1 - N2;
                }
                else if (operation == '*')
                {
                    resultat = N1 * N2;
                }
                else if (operation == '/')
                {
                    resultat = N1 / N2;
                }
                else if (operation == '√')
                {
                    resultat = Math.Sqrt(N1);
                }
                else if (operation == '^')
                {
                    resultat = N1 * N1;
                }
                else if (operation == '%')
                {
                    resultat = N1 * (N2 / 100);
                }

                TB_Resultat.Text = resultat.ToString();
            }

            // Mise à jour de N1 et de l'opération en cours
            N1 = double.Parse(TB_Resultat.Text);
            operation = newOperation;
            TB_Resultat.Text = "0";
        }

        // Gestionnaire d'événement lorsque l'utilisateur clique sur le bouton "="
        private void BTN_Equals_Click(object sender, RoutedEventArgs e)
        {
            if (operation != ' ')
            {
                // Si une opération est en cours, effectuer le calcul final
                N2 = double.Parse(TB_Resultat.Text);
                if (operation == '+')
                {
                    resultat = N1 + N2;
                }
                else if (operation == '-')
                {
                    resultat = N1 - N2;
                }
                else if (operation == '*')
                {
                    resultat = N1 * N2;
                }
                else if (operation == '/')
                {
                    resultat = N1 / N2;
                }
                else if (operation == '√')
                {
                    resultat = Math.Sqrt(N1);
                }
                else if (operation == '^')
                {
                    resultat = N1 * N1;
                }
                else if (operation == '%')
                {
                    resultat = N1 * (N2 / 100);
                }

                // Afficher le résultat final et réinitialiser l'opération
                TB_Resultat.Text = resultat.ToString();
                operation = ' ';
            }
        }

        // Gestionnaire d'événement lorsque l'utilisateur clique sur le bouton de la virgule
        private void BTN_Virgule_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si la chaîne actuellement affichée contient déjà une virgule
            if (!TB_Resultat.Text.Contains("."))
            {
                // Si elle n'en contient pas, ajouter la virgule
                TB_Resultat.Text += ".";
            }
        }
    }

}

