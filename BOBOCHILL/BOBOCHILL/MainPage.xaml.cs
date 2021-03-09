using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BOBOCHILL
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_2(object sender, RoutedEventArgs e)
        {
            
        }
        int naRedu = 1;
        int brBacanja = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            Random rnd = new Random();
            int d;
            d = rnd.Next(1, 7);
            Kocka.Text = Convert.ToString(d);
            if (d == 6)
            {
                if (naRedu == 1)
                {
                    B_Izlaz_1_.Text = B1.Text;
                }
                else if (naRedu == 2)
                {
                    Y_Izlaz_11_.Text = Y1.Text;
                }
                else if (naRedu == 3)
                {
                    G_Izlaz_21_.Text = G1.Text;
                }
                else if (naRedu == 4)
                {
                    R_Izlaz_31_.Text = R1.Text;
                }
            }
            brBacanja++;
            BrBac.Text = Convert.ToString(brBacanja);
                if(brBacanja==3)
                    {
                naRedu++;
                brBacanja = 0;
                    }
            
            if(naRedu==5)
            {
                naRedu = 1;
            }
        }

        private void Kocka_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }

        private void TextBlock_SelectionChanged_B1(object sender, RoutedEventArgs e)
        {
            B1.Text = "B1";
            
        }

        private void TextBlock_SelectionChanged_IzlazB(object sender, RoutedEventArgs e)
        {

        }

        private void BrBac_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
