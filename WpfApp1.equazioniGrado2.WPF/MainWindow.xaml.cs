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
using Week7.EquazioniGrado2.core;

namespace WpfApp1.equazioniGrado2.WPF
{
    
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public partial class MainWindow : Window
        {
            private double valueA;
            private double valueB;
            private double ValueC;

            private string operation;
            Equation eq = new Equation();
        private object risultato;

        public MainWindow()
            {
                InitializeComponent();
            }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }


        private void btnCancel_Click(object sender, RoutedEventArgs e)
            {
                risultato.Clear();
            }



        private void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            risultato.Clear();
        }
        private void btnUguale_Click(object sender, RoutedEventArgs e)
            {
                valueB = (string.IsNullOrEmpty(txtValue.Text)) ? 0 : double.Parse(txtValue.Text);
                switch (operation)
                {
                    case "moltiplica":
                        txtValue.Text = eq.A*B.ToString();
                        break;   
                    case "dividi":
                        var result = eq.Divisione(valueA, valueB);
                        txtValue.Text = result == null ? "Error" : result.ToString();
                        break;
                    default:
                        txtValue.Text = "Error";
                        break;
                }
            }

            private void menuExit(object sender, RoutedEventArgs e)
            {
                Close();
            }
        }
    }