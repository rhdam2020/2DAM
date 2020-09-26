using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Calculadora
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        TextBox tb;
        Int32 memoria1, memoria2, resultado;
        String operacion;
        public MainPage()
        {
            this.InitializeComponent();
            tb = (TextBox)FindName("pantalla");
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "1";
            }
            else {
                tb.Text = tb.Text + "1";
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "2";
            }
            else
            {
                tb.Text = tb.Text + "2";
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "3";
            }
            else
            {
                tb.Text = tb.Text + "3";
            }
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "Pulsa un numero";
            }
            else
            {
                memoria1 = Int32.Parse(tb.Text.ToString());
                operacion = "D";
                tb.Text = "";
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "4";
            }
            else
            {
                tb.Text = tb.Text + "4";
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "5";
            }
            else
            {
                tb.Text = tb.Text + "5";
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "6";
            }
            else
            {
                tb.Text = tb.Text + "6";
            }
        }

        private void btnProducto_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "Pulsa un numero";
            }
            else
            {
                memoria1 = Int32.Parse(tb.Text.ToString());
                operacion = "P";
                tb.Text = "";
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "7";
            }
            else
            {
                tb.Text = tb.Text + "7";
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "8";
            }
            else
            {
                tb.Text = tb.Text + "8";
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "9";
            }
            else
            {
                tb.Text = tb.Text + "9";
            }
        }

        private void btnMas_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "Pulsa un numero";
            }
            else {
                memoria1 = Int32.Parse(tb.Text.ToString());
                operacion = "S";
                tb.Text = "";
            }
        }

        private void btnatras_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.ToString().Equals(""))
            {

            }
            else {
                String serieNumerica;
                serieNumerica = tb.Text.ToString();
                serieNumerica = serieNumerica.Substring(0, serieNumerica.Length - 1);
                tb.Text = serieNumerica.Trim();
            }
        }

        private void btncero_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "0";
            }
            else
            {
                tb.Text = tb.Text + "0";
            }
        }

        private void btnigual_Click(object sender, RoutedEventArgs e)
        {
           
            if (!tb.Text.ToString().Equals("") && memoria1>=0) {
                memoria2 = Int32.Parse(tb.Text.ToString());
                switch (operacion){
                    case "S":
                        resultado = memoria1 + memoria2;
                        tb.Text = resultado + "";
                        break;
                    case "R":
                        resultado = memoria1 - memoria2;
                        tb.Text = resultado + "";
                        break;
                    case "P":
                        resultado = memoria1 * memoria2;
                        tb.Text = resultado + "";
                        break;
                    case "D":
                        if (memoria2 == 0)
                        {
                            tb.Text = "No se puede dividir por 0";
                        }
                        else {
                            resultado = memoria1 / memoria2;
                            tb.Text = resultado + "";
                        }
                        break;
                }
            }
        }

        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Equals(""))
            {
                tb.Text = "Pulsa un numero";
            }
            else
            {
                memoria1 = Int32.Parse(tb.Text.ToString());
                operacion = "R";
                tb.Text = "";
            }
        }
    }
}
