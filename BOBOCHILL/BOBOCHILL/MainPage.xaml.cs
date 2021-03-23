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
        int prviB1_Izaso = 1;
        int prviR1_Izaso = 0;
        int prviG1_Izaso = 0;
        int prviY2_Izaso = 0;

        int prviB2_Izaso = 1;
        int prviR2_Izaso = 0;
        int prviG2_Izaso = 0;
        int prviY1_Izaso = 0;

        int prviB3_Izaso = 1;
        int prviR3_Izaso = 0;
        int prviG3_Izaso = 0;
        int prviY3_Izaso = 0;

        int prviB4_Izaso = 1;
        int prviR4_Izaso = 0;
        int prviG4_Izaso = 0;
        int prviY4_Izaso = 0;

        int naRedu = 0;
        int brBacanja = 0;
        //Prva
        int pozicijaB1P = -1;
        int pozicijaR1P = -31;
        int pozicijaG1P = -21;
        int pozicijaY1P = -11;
        int pozicijaB1 = -1;
        int pozicijaR1 = -31;
        int pozicijaG1 = -21;
        int pozicijaY1 = -11;
        //Druga
        int pozicijaB2P = -1;
        int pozicijaR2P = -31;
        int pozicijaG2P = -21;
        int pozicijaY2P = -11;
        int pozicijaB2 = -1;
        int pozicijaR2 = -31;
        int pozicijaG2 = -21;
        int pozicijaY2 = -11;
        //Treca
        int pozicijaB3P = -1;
        int pozicijaR3P = -31;
        int pozicijaG3P = -21;
        int pozicijaY3P = -11;
        int pozicijaB3 = -1;
        int pozicijaR3 = -31;
        int pozicijaG3 = -21;
        int pozicijaY3 = -11;
        //Cetvrta
        int pozicijaB4P = -1;
        int pozicijaR4P = -31;
        int pozicijaG4P = -21;
        int pozicijaY4P = -11;
        int pozicijaB4 = -1;
        int pozicijaR4 = -31;
        int pozicijaG4 = -21;
        int pozicijaY4 = -11;
        int dozvola = 1;
        int d=0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            Random rnd = new Random();
            if (d == 6)
            {
                naRedu--; 
                if(naRedu==0)
                {
                    naRedu = 4;
                }
            }    
                
            d = rnd.Next(1, 7);
            Kocka.Text = Convert.ToString(d);
            
            if (dozvola == 1)
                brBacanja++;
            if (brBacanja >= 1)
            {
                
                    naRedu++;

                    brBacanja = 0;
                
            }

            if (naRedu == 5)
            {
                naRedu = 1;
            }
            Tko.Text = Convert.ToString(naRedu);
            dozvola = 1;
        }
            
        private void Kocka_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }

        private void TextBlock_SelectionChanged_B1(object sender, RoutedEventArgs e)
        {
           
            
        }

        private void TextBlock_SelectionChanged_IzlazB(object sender, RoutedEventArgs e)
        {

        }

        private void BrBac_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_polje(object sender, RoutedEventArgs e)
        {

        }

        private void BuB1_Click(object sender, RoutedEventArgs e)
        {
            dozvola = 0;
            pozicijaB1P = pozicijaB1;
            pozicijaG1P = pozicijaG1;
            pozicijaR1P = pozicijaR1;
            pozicijaY1P = pozicijaY1;
            if (naRedu == 1 && pozicijaB1 >= 0)
            {


                pozicijaB1 += d;
                if (pozicijaB1 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                    prviR1_Izaso = 0;
                }
                else if (pozicijaB1 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                    prviG1_Izaso = 0;
                }
                else if (pozicijaB1 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }

                else if (pozicijaB1 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaB1 == pozicijaG2)
                {
                    pozicijaG2 = -21;
                    prviG2_Izaso = 0;
                }
                else if (pozicijaB1 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }

                else if (pozicijaB1 == pozicijaR3)
                {
                    pozicijaR3 = -31;
                    prviR3_Izaso = 0;
                }
                else if (pozicijaB1 == pozicijaG3)
                {
                    pozicijaG3 = -21;
                    prviG3_Izaso = 0;
                }
                else if (pozicijaB1 == pozicijaY3)
                {
                    pozicijaY3 = -11;
                    prviY3_Izaso = 0;
                }

                else if (pozicijaB1 == pozicijaR4)
                {
                    pozicijaR4 = -31;
                    prviR4_Izaso = 0;
                }
                else if (pozicijaB1 == pozicijaG4)
                {
                    pozicijaG4 = -21;
                    prviG4_Izaso = 0;
                }
                else if (pozicijaB1 == pozicijaY4)
                {
                    pozicijaY4 = -11;
                    prviY4_Izaso = 0;
                }
               
            


                if (pozicijaB1 > 44)
                {
                    pozicijaB1 -= d;

                }

            }
            else if (naRedu == 2 && pozicijaY1 >= 0)
            {

                pozicijaY1 += d;
                if (pozicijaY1 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                    prviR1_Izaso = 0;
                }
                else if (pozicijaY1 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                    prviG1_Izaso = 0;
                }
                else if (pozicijaY1 == pozicijaB1)
                {
                    pozicijaB1 = -11;
                    prviB1_Izaso = 0;
                }

                else if (pozicijaY1 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaY1 == pozicijaG2)
                {
                    pozicijaG2 = -21;
                    prviG2_Izaso = 0;
                }
                else if (pozicijaY1 == pozicijaB2)
                {
                    pozicijaB2 = -11;
                    prviB2_Izaso = 0;
                }

                else if (pozicijaY1 == pozicijaR3)
                {
                    pozicijaR3 = -31;
                    prviR3_Izaso = 0;
                }
                else if (pozicijaY1 == pozicijaG3)
                {
                    pozicijaG3 = -21;
                    prviG3_Izaso = 0;
                }
                else if (pozicijaY1 == pozicijaB3)
                {
                    pozicijaB3 = -11;
                    prviB3_Izaso = 0;
                }

                else if (pozicijaY1 == pozicijaR4)
                {
                    pozicijaR4 = -31;
                    prviR4_Izaso = 0;
                }
                else if (pozicijaY1 == pozicijaG4)
                {
                    pozicijaG4 = -21;
                    prviG4_Izaso = 0;
                }
                else if (pozicijaY1 == pozicijaB4)
                {
                    pozicijaB4 = -11;
                    prviB4_Izaso = 0;
                }
                if (pozicijaY1 >= 40)
                {
                    pozicijaY1 -= 40;
                    prviY1_Izaso = 1;
                }
                if (prviY1_Izaso == 1 && pozicijaY1 > 14)
                {
                    pozicijaY1 -= d;
                }

            }
            else if (naRedu == 3 && pozicijaG1 >= 0)
            {

                pozicijaG1 += d;
                if (pozicijaG1 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                    prviR1_Izaso = 0;
                }
                else if (pozicijaG1 == pozicijaB1)
                {
                    pozicijaB1 = -21;
                    prviB1_Izaso = 0;
                }
                else if (pozicijaG1 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }

                else if (pozicijaG1 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaG1 == pozicijaB2)
                {
                    pozicijaB2 = -21;
                    prviB2_Izaso = 0;
                }
                else if (pozicijaG1 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }

                else if (pozicijaG1 == pozicijaR3)
                {
                    pozicijaR3 = -31;
                    prviR3_Izaso = 0;
                }
                else if (pozicijaG1 == pozicijaB3)
                {
                    pozicijaB3 = -21;
                    prviB3_Izaso = 0;
                }
                else if (pozicijaG1 == pozicijaY3)
                {
                    pozicijaY3 = -11;
                    prviY3_Izaso = 0;
                }

                else if (pozicijaG1 == pozicijaR4)
                {
                    pozicijaR4 = -31;
                    prviR4_Izaso = 0;
                }
                else if (pozicijaG1 == pozicijaB4)
                {
                    pozicijaB4 = -21;
                    prviB4_Izaso = 0;
                }
                else if (pozicijaG1 == pozicijaY4)
                {
                    pozicijaY4 = -11;
                    prviY4_Izaso = 0;
                }
                if (prviG1_Izaso == 1 && pozicijaG1 > 24)
                {
                    pozicijaG1 -= d;
                }
                if (pozicijaG1 >= 40)
                {
                    pozicijaG1 -= 40;
                    prviG1_Izaso = 1;

                }
            }
            else if (naRedu == 4 && pozicijaR1 >= 0)
            {
                pozicijaR1 += d;
                if (pozicijaR1 == pozicijaB1)
                {
                    pozicijaB1 = -31;
                    prviB1_Izaso = 0;
                }
                else if (pozicijaR1 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                    prviG1_Izaso = 0;
                }
                else if (pozicijaR1 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }

                else if (pozicijaR1 == pozicijaB2)
                {
                    pozicijaB2 = -31;
                    prviB2_Izaso = 0;
                }
                else if (pozicijaR1 == pozicijaG2)
                {
                    pozicijaG2 = -21;
                    prviG2_Izaso = 0;
                }
                else if (pozicijaR1 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }

                else if (pozicijaR1 == pozicijaB3)
                {
                    pozicijaB3 = -31;
                    prviB3_Izaso = 0;
                }
                else if (pozicijaR1 == pozicijaG3)
                {
                    pozicijaG3 = -21;
                    prviG3_Izaso = 0;
                }
                else if (pozicijaR1 == pozicijaY3)
                {
                    pozicijaY3 = -11;
                    prviY3_Izaso = 0;
                }

                else if (pozicijaR1 == pozicijaB4)
                {
                    pozicijaB4 = -31;
                    prviB4_Izaso = 0;
                }
                else if (pozicijaR1 == pozicijaG4)
                {
                    pozicijaG4 = -21;
                    prviG4_Izaso = 0;
                }
                else if (pozicijaR1 == pozicijaY4)
                {
                    pozicijaY4 = -11;
                    prviY4_Izaso = 0;
                }
                if (pozicijaR1 >= 40)
                {
                    pozicijaR1 -= 40;
                    prviR1_Izaso = 1;

                }
                if (prviR1_Izaso == 1 && pozicijaR1 > 34)
                {
                    pozicijaR1 -= d;
                }
            }

            if (d == 6)
            {
                if (naRedu == 1)
                {

                    if (pozicijaB1 < 0)
                    {
                        B_Izlaz_1_.Text = B1.Text;
                        pozicijaB1 = Math.Abs(pozicijaB1);
                    }



                }
                else if (naRedu == 2)
                {

                    if (pozicijaY1 < 0)
                    {
                        Y_Izlaz_11_.Text = Y1.Text;
                        pozicijaY1 = Math.Abs(pozicijaY1);
                    }

                }
                else if (naRedu == 3)
                {

                    if (pozicijaG1 < 0)
                    {
                        G_Izlaz_21_.Text = G1.Text;
                        pozicijaG1 = Math.Abs(pozicijaG1);
                    }

                }
                else if (naRedu == 4)
                {

                    if (pozicijaR1 < 0)
                    {
                        R_Izlaz_31_.Text = R1.Text;
                        pozicijaR1 = Math.Abs(pozicijaR1);
                    }

                }
            }



            if (naRedu == 1 && pozicijaB1 >= 0)
            {
                switch (pozicijaB1P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = " .";
                        break;
                    case 12:
                        Poz12.Text = " .";
                        break;
                    case 13:
                        Poz13.Text = " .";
                        break;
                    case 14:
                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 40:
                        B_Kraj_0_.Text = " .";
                        break;
                    case 41:
                        BUlaz1.Text = " .";
                        break;
                    case 42:
                        BUlaz2.Text = " .";
                        break;
                    case 43:
                        BUlaz3.Text = " .";
                        break;
                    case 44:
                        BUlaz4.Text = " .";
                        break;


                }
                switch (pozicijaB1)
                {
                    case 1:
                        B_Izlaz_1_.Text = B1.Text;
                        break;
                    case 2:
                        Poz2.Text = B1.Text;
                        break;
                    case 3:
                        Poz3.Text = B1.Text;
                        break;
                    case 4:
                        Poz4.Text = B1.Text;
                        break;
                    case 5:
                        Poz5.Text = B1.Text;
                        break;
                    case 6:
                        Poz6.Text = B1.Text;
                        break;
                    case 7:
                        Poz7.Text = B1.Text;
                        break;
                    case 8:
                        Poz8.Text = B1.Text;
                        break;
                    case 9:
                        Poz9.Text = B1.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = B1.Text;
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = B1.Text;
                        break;
                    case 12:
                        Poz12.Text = B1.Text;
                        break;
                    case 13:
                        Poz13.Text = B1.Text;
                        break;
                    case 14:
                        Poz14.Text = B1.Text;
                        break;
                    case 15:
                        Poz15.Text = B1.Text;
                        break;
                    case 16:
                        Poz16.Text = B1.Text;
                        break;
                    case 17:
                        Poz17.Text = B1.Text;
                        break;
                    case 18:
                        Poz18.Text = B1.Text;
                        break;
                    case 19:
                        Poz19.Text = B1.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = B1.Text;
                        break;
                    case 21:
                        G_Izlaz_21_.Text = B1.Text;
                        break;
                    case 22:
                        Poz22.Text = B1.Text;
                        break;
                    case 23:
                        Poz23.Text = B1.Text;
                        break;
                    case 24:
                        Poz24.Text = B1.Text;
                        break;
                    case 25:
                        Poz25.Text = B1.Text;
                        break;
                    case 26:
                        Poz26.Text = B1.Text;
                        break;
                    case 27:
                        Poz27.Text = B1.Text;
                        break;
                    case 28:
                        Poz28.Text = B1.Text;
                        break;
                    case 29:
                        Poz29.Text = B1.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = B1.Text;
                        break;
                    case 31:
                        R_Izlaz_31_.Text = B1.Text;
                        break;
                    case 32:
                        Poz32.Text = B1.Text;
                        break;
                    case 33:
                        Poz33.Text = B1.Text;
                        break;
                    case 34:
                        Poz34.Text = B1.Text;
                        break;
                    case 35:
                        Poz35.Text = B1.Text;
                        break;
                    case 36:
                        Poz36.Text = B1.Text;
                        break;
                    case 37:
                        Poz37.Text = B1.Text;
                        break;
                    case 38:
                        Poz38.Text = B1.Text;
                        break;
                    case 39:
                        Poz39.Text = B1.Text;
                        break;
                    case 40:
                        B_Kraj_0_.Text = B1.Text;
                        pozicijaB1 = 0;
                        break;
                    case 41:
                        BUlaz1.Text = B1.Text;
                        break;
                    case 42:
                        BUlaz2.Text = B1.Text;
                        break;
                    case 43:
                        BUlaz3.Text = B1.Text;
                        break;
                    case 44:
                        BUlaz4.Text = B1.Text;
                        break;


                }
            }
            else if (naRedu == 2 && pozicijaY1 >= 0)
            {
                switch (pozicijaY1P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:

                        Y_Izlaz_11_.Text = " .";

                        break;
                    case 12:

                        Poz12.Text = " .";
                        break;
                    case 13:

                        Poz13.Text = " .";
                        break;
                    case 14:

                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 40:
                        B_Kraj_0_.Text = " .";
                        break;


                }
                switch (pozicijaY1)
                {
                    case 1:
                        B_Izlaz_1_.Text = Y1.Text;
                        break;
                    case 2:
                        Poz2.Text = Y1.Text;
                        break;
                    case 3:
                        Poz3.Text = Y1.Text;
                        break;
                    case 4:
                        Poz4.Text = Y1.Text;
                        break;
                    case 5:
                        Poz5.Text = Y1.Text;
                        break;
                    case 6:
                        Poz6.Text = Y1.Text;
                        break;
                    case 7:
                        Poz7.Text = Y1.Text;
                        break;
                    case 8:
                        Poz8.Text = Y1.Text;
                        break;
                    case 9:
                        Poz9.Text = Y1.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = Y1.Text;
                        break;
                    case 11:
                        if (prviY1_Izaso == 0)
                            Y_Izlaz_11_.Text = Y1.Text;
                        else
                            YUlaz1.Text = Y1.Text;

                        break;
                    case 12:
                        if (prviY1_Izaso == 0)
                            Poz12.Text = Y1.Text;
                        else
                            YUlaz2.Text = Y1.Text;

                        break;
                    case 13:
                        if (prviY1_Izaso == 0)
                            Poz13.Text = Y1.Text;
                        else
                            YUlaz3.Text = Y1.Text;

                        break;
                    case 14:
                        if (prviY1_Izaso == 0)
                            Poz14.Text = Y1.Text;
                        else
                            YUlaz4.Text = Y1.Text;

                        break;
                    case 15:
                        Poz15.Text = Y1.Text;
                        break;
                    case 16:
                        Poz16.Text = Y1.Text;
                        break;
                    case 17:
                        Poz17.Text = Y1.Text;
                        break;
                    case 18:
                        Poz18.Text = Y1.Text;
                        break;
                    case 19:
                        Poz19.Text = Y1.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = Y1.Text;
                        break;
                    case 21:
                        G_Izlaz_21_.Text = Y1.Text;
                        break;
                    case 22:
                        Poz22.Text = Y1.Text;
                        break;
                    case 23:
                        Poz23.Text = Y1.Text;
                        break;
                    case 24:
                        Poz24.Text = Y1.Text;
                        break;
                    case 25:
                        Poz25.Text = Y1.Text;
                        break;
                    case 26:
                        Poz26.Text = Y1.Text;
                        break;
                    case 27:
                        Poz27.Text = Y1.Text;
                        break;
                    case 28:
                        Poz28.Text = Y1.Text;
                        break;
                    case 29:
                        Poz29.Text = Y1.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = Y1.Text;
                        break;
                    case 31:
                        R_Izlaz_31_.Text = Y1.Text;
                        break;
                    case 32:
                        Poz32.Text = Y1.Text;
                        break;
                    case 33:
                        Poz33.Text = Y1.Text;
                        break;
                    case 34:
                        Poz34.Text = Y1.Text;
                        break;
                    case 35:
                        Poz35.Text = Y1.Text;
                        break;
                    case 36:
                        Poz36.Text = Y1.Text;
                        break;
                    case 37:
                        Poz37.Text = Y1.Text;
                        break;
                    case 38:
                        Poz38.Text = Y1.Text;
                        break;
                    case 39:
                        Poz39.Text = Y1.Text;
                        break;
                    case 40:
                        B_Kraj_0_.Text = Y1.Text;
                        pozicijaY1 = 0;
                        break;


                }
            }
            else if (naRedu == 3 && pozicijaG1 >= 0)
            {
                switch (pozicijaG1P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = " .";
                        break;
                    case 12:
                        Poz12.Text = " .";
                        break;
                    case 13:
                        Poz13.Text = " .";
                        break;
                    case 14:
                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 40:
                        B_Kraj_0_.Text = " .";
                        break;


                }
                switch (pozicijaG1)
                {
                    case 1:
                        B_Izlaz_1_.Text = G1.Text;
                        break;
                    case 2:
                        Poz2.Text = G1.Text;
                        break;
                    case 3:
                        Poz3.Text = G1.Text;
                        break;
                    case 4:
                        Poz4.Text = G1.Text;
                        break;
                    case 5:
                        Poz5.Text = G1.Text;
                        break;
                    case 6:
                        Poz6.Text = G1.Text;
                        break;
                    case 7:
                        Poz7.Text = G1.Text;
                        break;
                    case 8:
                        Poz8.Text = G1.Text;
                        break;
                    case 9:
                        Poz9.Text = G1.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = G1.Text;
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = G1.Text;
                        break;
                    case 12:
                        Poz12.Text = G1.Text;
                        break;
                    case 13:
                        Poz13.Text = G1.Text;
                        break;
                    case 14:
                        Poz14.Text = G1.Text;
                        break;
                    case 15:
                        Poz15.Text = G1.Text;
                        break;
                    case 16:
                        Poz16.Text = G1.Text;
                        break;
                    case 17:
                        Poz17.Text = G1.Text;
                        break;
                    case 18:
                        Poz18.Text = G1.Text;
                        break;
                    case 19:
                        Poz19.Text = G1.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = G1.Text;
                        break;
                    case 21:
                        if (prviG1_Izaso == 0)
                            G_Izlaz_21_.Text = G1.Text;
                        else
                            GUlaz1.Text = G1.Text;
                        break;
                    case 22:
                        if (prviG1_Izaso == 0)
                            Poz22.Text = G1.Text;
                        else
                            GUlaz2.Text = G1.Text;

                        break;
                    case 23:
                        if (prviG1_Izaso == 0)
                            Poz23.Text = G1.Text;
                        else
                            GUlaz3.Text = G1.Text;

                        break;
                    case 24:
                        if (prviG1_Izaso == 0)
                            Poz24.Text = G1.Text;
                        else
                            GUlaz4.Text = G1.Text;

                        break;
                    case 25:
                        Poz25.Text = G1.Text;
                        break;
                    case 26:
                        Poz26.Text = G1.Text;
                        break;
                    case 27:
                        Poz27.Text = G1.Text;
                        break;
                    case 28:
                        Poz28.Text = G1.Text;
                        break;
                    case 29:
                        Poz29.Text = G1.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = G1.Text;
                        break;
                    case 31:
                        R_Izlaz_31_.Text = G1.Text;
                        break;
                    case 32:
                        Poz32.Text = G1.Text;
                        break;
                    case 33:
                        Poz33.Text = G1.Text;
                        break;
                    case 34:
                        Poz34.Text = G1.Text;
                        break;
                    case 35:
                        Poz35.Text = G1.Text;
                        break;
                    case 36:
                        Poz36.Text = G1.Text;
                        break;
                    case 37:
                        Poz37.Text = G1.Text;
                        break;
                    case 38:
                        Poz38.Text = G1.Text;
                        break;
                    case 39:
                        Poz39.Text = G1.Text;
                        break;
                    case 40:
                        B_Kraj_0_.Text = G1.Text;
                        pozicijaG1 = 0;
                        break;


                }
            }
            else if (naRedu == 4 && pozicijaR1 >= 0)
            {
                switch (pozicijaR1P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = " .";
                        break;
                    case 12:
                        Poz12.Text = " .";
                        break;
                    case 13:
                        Poz13.Text = " .";
                        break;
                    case 14:
                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 0:
                        B_Kraj_0_.Text = " .";
                        break;


                }
                switch (pozicijaR1)
                {
                    case 1:
                        B_Izlaz_1_.Text = R1.Text;
                        break;
                    case 2:
                        Poz2.Text = R1.Text;
                        break;
                    case 3:
                        Poz3.Text = R1.Text;
                        break;
                    case 4:
                        Poz4.Text = R1.Text;
                        break;
                    case 5:
                        Poz5.Text = R1.Text;
                        break;
                    case 6:
                        Poz6.Text = R1.Text;
                        break;
                    case 7:
                        Poz7.Text = R1.Text;
                        break;
                    case 8:
                        Poz8.Text = R1.Text;
                        break;
                    case 9:
                        Poz9.Text = R1.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = R1.Text;
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = R1.Text;
                        break;
                    case 12:
                        Poz12.Text = R1.Text;
                        break;
                    case 13:
                        Poz13.Text = R1.Text;
                        break;
                    case 14:
                        Poz14.Text = R1.Text;
                        break;
                    case 15:
                        Poz15.Text = R1.Text;
                        break;
                    case 16:
                        Poz16.Text = R1.Text;
                        break;
                    case 17:
                        Poz17.Text = R1.Text;
                        break;
                    case 18:
                        Poz18.Text = R1.Text;
                        break;
                    case 19:
                        Poz19.Text = R1.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = R1.Text;
                        break;
                    case 21:
                        G_Izlaz_21_.Text = R1.Text;
                        break;
                    case 22:
                        Poz22.Text = R1.Text;
                        break;
                    case 23:
                        Poz23.Text = R1.Text;
                        break;
                    case 24:
                        Poz24.Text = R1.Text;
                        break;
                    case 25:
                        Poz25.Text = R1.Text;
                        break;
                    case 26:
                        Poz26.Text = R1.Text;
                        break;
                    case 27:
                        Poz27.Text = R1.Text;
                        break;
                    case 28:
                        Poz28.Text = R1.Text;
                        break;
                    case 29:
                        Poz29.Text = R1.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = R1.Text;
                        break;
                    case 31:
                        if (prviR1_Izaso == 0)
                            R_Izlaz_31_.Text = R1.Text;
                        else
                            RUlaz1.Text = R1.Text;
                        break;
                    case 32:
                        if (prviR1_Izaso == 0)
                            Poz32.Text = R1.Text;
                        else
                            RUlaz2.Text = R1.Text;

                        break;
                    case 33:
                        if (prviR1_Izaso == 0)
                            Poz33.Text = R1.Text;
                        else
                            RUlaz3.Text = R1.Text;

                        break;
                    case 34:
                        if (prviR1_Izaso == 0)
                            Poz34.Text = R1.Text;
                        else
                            RUlaz4.Text = R1.Text;

                        break;
                    case 35:
                        Poz35.Text = R1.Text;
                        break;
                    case 36:
                        Poz36.Text = R1.Text;
                        break;
                    case 37:
                        Poz37.Text = R1.Text;
                        break;
                    case 38:
                        Poz38.Text = R1.Text;
                        break;
                    case 39:
                        Poz39.Text = R1.Text;
                        break;
                    case 40:
                        B_Kraj_0_.Text = R1.Text;
                        pozicijaR1 = 0;
                        break;


                }
            }
            brBacanja++;
          
            
            if (BUlaz1.Text!="." && BUlaz2.Text != "." && BUlaz3.Text != "." && BUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je plavi igrač!!!";
            }
            else if(RUlaz1.Text != "." && RUlaz2.Text != "." && RUlaz3.Text != "." && RUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je crveni igrač!!!";
            }
            else if(YUlaz1.Text != "." && YUlaz2.Text != "." && YUlaz3.Text != "." && YUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je žuti igrač!!!";
            }
            else if(GUlaz1.Text != "." && GUlaz2.Text != "." && GUlaz3.Text != "." && GUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je zeleni igrač!!!";
            }

        }




        //Drugi klosari




        private void BuB2_Click(object sender, RoutedEventArgs e)
        {
            dozvola = 0;
            pozicijaB2P = pozicijaB2;
            pozicijaG2P = pozicijaG2;
            pozicijaR2P = pozicijaR2;
            pozicijaY2P = pozicijaY2;
            if (naRedu == 1 && pozicijaB2 >= 0)
            {


                pozicijaB2 += d;
                if (pozicijaB2 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                    prviR1_Izaso = 0;
                }
                else if (pozicijaB2 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                    prviG1_Izaso = 0;
                }
                else if (pozicijaB2 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }

                else if (pozicijaB2 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaB2 == pozicijaG2)
                {
                    pozicijaG2 = -21;
                    prviG2_Izaso = 0;
                }
                else if (pozicijaB2 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }

                else if (pozicijaB2 == pozicijaR3)
                {
                    pozicijaR3 = -31;
                    prviR3_Izaso = 0;
                }
                else if (pozicijaB2 == pozicijaG3)
                {
                    pozicijaG3 = -21;
                    prviG3_Izaso = 0;
                }
                else if (pozicijaB2 == pozicijaY3)
                {
                    pozicijaY3 = -11;
                    prviY3_Izaso = 0;
                }

                else if (pozicijaB2 == pozicijaR4)
                {
                    pozicijaR4 = -31;
                    prviR4_Izaso = 0;
                }
                else if (pozicijaB2 == pozicijaG4)
                {
                    pozicijaG4 = -21;
                    prviG4_Izaso = 0;
                }
                else if (pozicijaB2 == pozicijaY4)
                {
                    pozicijaY4 = -11;
                    prviY4_Izaso = 0;
                }


                if (pozicijaB2 > 44)
                {
                    pozicijaB2 -= d;

                }

            }
            else if (naRedu == 2 && pozicijaY2 >= 0)
            {

                pozicijaY2 += d;
                if (pozicijaY2 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                    prviR1_Izaso = 0;
                }
                else if (pozicijaY2 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                    prviG1_Izaso = 0;
                }
                else if (pozicijaY2 == pozicijaB1)
                {
                    pozicijaB1 = -11;
                    prviB1_Izaso = 0;
                }

                else if (pozicijaY2 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaY2 == pozicijaG2)
                {
                    pozicijaG2 = -21;
                    prviG2_Izaso = 0;
                }
                else if (pozicijaY2 == pozicijaB2)
                {
                    pozicijaB2 = -11;
                    prviB2_Izaso = 0;
                }

                else if (pozicijaY2 == pozicijaR3)
                {
                    pozicijaR3 = -31;
                    prviR3_Izaso = 0;
                }
                else if (pozicijaY2 == pozicijaG3)
                {
                    pozicijaG3 = -21;
                    prviG3_Izaso = 0;
                }
                else if (pozicijaY2 == pozicijaB3)
                {
                    pozicijaB3 = -11;
                    prviB3_Izaso = 0;
                }

                else if (pozicijaY2 == pozicijaR4)
                {
                    pozicijaR4 = -31;
                    prviR4_Izaso = 0;
                }
                else if (pozicijaY2 == pozicijaG4)
                {
                    pozicijaG4 = -21;
                    prviG4_Izaso = 0;
                }
                else if (pozicijaY2 == pozicijaB4)
                {
                    pozicijaB4 = -11;
                    prviB4_Izaso = 0;
                }
                if (pozicijaY2 >= 40)
                {
                    pozicijaY2 -= 40;
                    prviY2_Izaso = 1;
                }
               
                if (prviY2_Izaso == 1 && pozicijaY2 > 14)
                {
                    pozicijaY2 -= d;
                }

            }
            else if (naRedu == 3 && pozicijaG2 >= 0)
            {

                pozicijaG2 += d;
                if (pozicijaG2 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                    prviR1_Izaso = 0;
                }
                else if (pozicijaG2 == pozicijaB1)
                {
                    pozicijaB1 = -21;
                    prviB1_Izaso = 0;
                }
                else if (pozicijaG2 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }

                else if (pozicijaG2 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaG2 == pozicijaB2)
                {
                    pozicijaB2 = -21;
                    prviB2_Izaso = 0;
                }
                else if (pozicijaG2 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }

                else if (pozicijaG2 == pozicijaR3)
                {
                    pozicijaR3 = -31;
                    prviR3_Izaso = 0;
                }
                else if (pozicijaG2 == pozicijaB3)
                {
                    pozicijaB3 = -21;
                    prviB3_Izaso = 0;
                }
                else if (pozicijaG2 == pozicijaY3)
                {
                    pozicijaY3 = -11;
                    prviY3_Izaso = 0;
                }

                else if (pozicijaG2 == pozicijaR4)
                {
                    pozicijaR4 = -31;
                    prviR4_Izaso = 0;
                }
                else if (pozicijaG2 == pozicijaB4)
                {
                    pozicijaB4 = -21;
                    prviB4_Izaso = 0;
                }
                else if (pozicijaG2 == pozicijaY4)
                {
                    pozicijaY4 = -11;
                    prviY4_Izaso = 0;
                }
                if (pozicijaG2 >= 40)
                {
                    pozicijaG2 -= 40;
                    prviG2_Izaso = 1;


                }
                if (prviG2_Izaso == 1 && pozicijaG2 > 24)
                {
                    pozicijaG2 -= d;
                }
            }
            else if (naRedu == 4 && pozicijaR2 >= 0)
            {
                pozicijaR2 += d;
                if (pozicijaR2 == pozicijaB1)
                {
                    pozicijaB1 = -31;
                    prviB1_Izaso = 0;
                }
                else if (pozicijaR2 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                    prviG1_Izaso = 0;
                }
                else if (pozicijaR2 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }

                else if (pozicijaR2 == pozicijaB2)
                {
                    pozicijaB2 = -31;
                    prviB2_Izaso = 0;
                }
                else if (pozicijaR2 == pozicijaG2)
                {
                    pozicijaG2 = -21;
                    prviG2_Izaso = 0;
                }
                else if (pozicijaR2 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }

                else if (pozicijaR2 == pozicijaB3)
                {
                    pozicijaB3 = -31;
                    prviB3_Izaso = 0;
                }
                else if (pozicijaR2 == pozicijaG3)
                {
                    pozicijaG3 = -21;
                    prviG3_Izaso = 0;
                }
                else if (pozicijaR2 == pozicijaY3)
                {
                    pozicijaY3 = -11;
                    prviY3_Izaso = 0;
                }

                else if (pozicijaR2 == pozicijaB4)
                {
                    pozicijaB4 = -31;
                    prviB4_Izaso = 0;
                }
                else if (pozicijaR2 == pozicijaG4)
                {
                    pozicijaG4 = -21;
                    prviG4_Izaso = 0;
                }
                else if (pozicijaR2 == pozicijaY4)
                {
                    pozicijaY4 = -11;
                    prviY4_Izaso = 0;
                }
                if (pozicijaR2 >= 40)
                {
                    pozicijaR2 -= 40;
                    prviR2_Izaso = 1;

                }
                if (prviR2_Izaso == 1 && pozicijaR2 > 34)
                {
                    pozicijaR2 -= d;
                }
            }

            if (d == 6)
            {
                if (naRedu == 1)
                {

                    if (pozicijaB2 < 0)
                    {
                        B_Izlaz_1_.Text = B2.Text;
                        pozicijaB2 = Math.Abs(pozicijaB2);
                    }



                }
                else if (naRedu == 2)
                {

                    if (pozicijaY2 < 0)
                    {
                        Y_Izlaz_11_.Text = Y2.Text;
                        pozicijaY2 = Math.Abs(pozicijaY2);
                    }

                }
                else if (naRedu == 3)
                {

                    if (pozicijaG2 < 0)
                    {
                        G_Izlaz_21_.Text = G2.Text;
                        pozicijaG2 = Math.Abs(pozicijaG2);
                    }

                }
                else if (naRedu == 4)
                {

                    if (pozicijaR2 < 0)
                    {
                        R_Izlaz_31_.Text = R2.Text;
                        pozicijaR2 = Math.Abs(pozicijaR2);
                    }

                }
            }



            if (naRedu == 1 && pozicijaB2 >= 0)
            {
                switch (pozicijaB2P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = " .";
                        break;
                    case 12:
                        Poz12.Text = " .";
                        break;
                    case 13:
                        Poz13.Text = " .";
                        break;
                    case 14:
                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 40:
                        B_Kraj_0_.Text = " .";
                        break;
                    case 41:
                        BUlaz1.Text = " .";
                        break;
                    case 42:
                        BUlaz2.Text = " .";
                        break;
                    case 43:
                        BUlaz3.Text = " .";
                        break;
                    case 44:
                        BUlaz4.Text = " .";
                        break;


                }
                switch (pozicijaB2)
                {
                    case 1:
                        B_Izlaz_1_.Text = B2.Text;
                        break;
                    case 2:
                        Poz2.Text = B2.Text;
                        break;
                    case 3:
                        Poz3.Text = B2.Text;
                        break;
                    case 4:
                        Poz4.Text = B2.Text;
                        break;
                    case 5:
                        Poz5.Text = B2.Text;
                        break;
                    case 6:
                        Poz6.Text = B2.Text;
                        break;
                    case 7:
                        Poz7.Text = B2.Text;
                        break;
                    case 8:
                        Poz8.Text = B2.Text;
                        break;
                    case 9:
                        Poz9.Text = B2.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = B2.Text;
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = B2.Text;
                        break;
                    case 12:
                        Poz12.Text = B2.Text;
                        break;
                    case 13:
                        Poz13.Text = B2.Text;
                        break;
                    case 14:
                        Poz14.Text = B2.Text;
                        break;
                    case 15:
                        Poz15.Text = B2.Text;
                        break;
                    case 16:
                        Poz16.Text = B2.Text;
                        break;
                    case 17:
                        Poz17.Text = B2.Text;
                        break;
                    case 18:
                        Poz18.Text = B2.Text;
                        break;
                    case 19:
                        Poz19.Text = B2.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = B2.Text;
                        break;
                    case 21:
                        G_Izlaz_21_.Text = B2.Text;
                        break;
                    case 22:
                        Poz22.Text = B2.Text;
                        break;
                    case 23:
                        Poz23.Text = B2.Text;
                        break;
                    case 24:
                        Poz24.Text = B2.Text;
                        break;
                    case 25:
                        Poz25.Text = B2.Text;
                        break;
                    case 26:
                        Poz26.Text = B2.Text;
                        break;
                    case 27:
                        Poz27.Text = B2.Text;
                        break;
                    case 28:
                        Poz28.Text = B2.Text;
                        break;
                    case 29:
                        Poz29.Text = B2.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = B2.Text;
                        break;
                    case 31:
                        R_Izlaz_31_.Text = B2.Text;
                        break;
                    case 32:
                        Poz32.Text = B2.Text;
                        break;
                    case 33:
                        Poz33.Text = B2.Text;
                        break;
                    case 34:
                        Poz34.Text = B2.Text;
                        break;
                    case 35:
                        Poz35.Text = B2.Text;
                        break;
                    case 36:
                        Poz36.Text = B2.Text;
                        break;
                    case 37:
                        Poz37.Text = B2.Text;
                        break;
                    case 38:
                        Poz38.Text = B2.Text;
                        break;
                    case 39:
                        Poz39.Text = B2.Text;
                        break;
                    case 40:
                        B_Kraj_0_.Text = B2.Text;
                        pozicijaB2 = 0;
                        break;
                    case 41:
                        BUlaz1.Text = B2.Text;
                        break;
                    case 42:
                        BUlaz2.Text = B2.Text;
                        break;
                    case 43:
                        BUlaz3.Text = B2.Text;
                        break;
                    case 44:
                        BUlaz4.Text = B2.Text;
                        break;


                }
            }
            else if (naRedu == 2 && pozicijaY2 >= 0)
            {
                switch (pozicijaY2P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:

                        Y_Izlaz_11_.Text = " .";

                        break;
                    case 12:

                        Poz12.Text = " .";
                        break;
                    case 13:

                        Poz13.Text = " .";
                        break;
                    case 14:

                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 0:
                        B_Kraj_0_.Text = " .";
                        break;


                }
                switch (pozicijaY2)
                {
                    case 1:
                        B_Izlaz_1_.Text = Y2.Text;
                        break;
                    case 2:
                        Poz2.Text = Y2.Text;
                        break;
                    case 3:
                        Poz3.Text = Y2.Text;
                        break;
                    case 4:
                        Poz4.Text = Y2.Text;
                        break;
                    case 5:
                        Poz5.Text = Y2.Text;
                        break;
                    case 6:
                        Poz6.Text = Y2.Text;
                        break;
                    case 7:
                        Poz7.Text = Y2.Text;
                        break;
                    case 8:
                        Poz8.Text = Y2.Text;
                        break;
                    case 9:
                        Poz9.Text = Y2.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = Y2.Text;
                        break;
                    case 11:
                        if (prviY2_Izaso == 0)
                            Y_Izlaz_11_.Text = Y2.Text;
                        else
                            YUlaz1.Text = Y2.Text;

                        break;
                    case 12:
                        if (prviY2_Izaso == 0)
                            Poz12.Text = Y2.Text;
                        else
                            YUlaz2.Text = Y2.Text;

                        break;
                    case 13:
                        if (prviY2_Izaso == 0)
                            Poz13.Text = Y2.Text;
                        else
                            YUlaz3.Text = Y2.Text;

                        break;
                    case 14:
                        if (prviY2_Izaso == 0)
                            Poz14.Text = Y2.Text;
                        else
                            YUlaz4.Text = Y2.Text;

                        break;
                    case 15:
                        Poz15.Text = Y2.Text;
                        break;
                    case 16:
                        Poz16.Text = Y2.Text;
                        break;
                    case 17:
                        Poz17.Text = Y2.Text;
                        break;
                    case 18:
                        Poz18.Text = Y2.Text;
                        break;
                    case 19:
                        Poz19.Text = Y2.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = Y2.Text;
                        break;
                    case 21:
                        G_Izlaz_21_.Text = Y2.Text;
                        break;
                    case 22:
                        Poz22.Text = Y2.Text;
                        break;
                    case 23:
                        Poz23.Text = Y2.Text;
                        break;
                    case 24:
                        Poz24.Text = Y2.Text;
                        break;
                    case 25:
                        Poz25.Text = Y2.Text;
                        break;
                    case 26:
                        Poz26.Text = Y2.Text;
                        break;
                    case 27:
                        Poz27.Text = Y2.Text;
                        break;
                    case 28:
                        Poz28.Text = Y2.Text;
                        break;
                    case 29:
                        Poz29.Text = Y2.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = Y2.Text;
                        break;
                    case 31:
                        R_Izlaz_31_.Text = Y2.Text;
                        break;
                    case 32:
                        Poz32.Text = Y2.Text;
                        break;
                    case 33:
                        Poz33.Text = Y2.Text;
                        break;
                    case 34:
                        Poz34.Text = Y2.Text;
                        break;
                    case 35:
                        Poz35.Text = Y2.Text;
                        break;
                    case 36:
                        Poz36.Text = Y2.Text;
                        break;
                    case 37:
                        Poz37.Text = Y2.Text;
                        break;
                    case 38:
                        Poz38.Text = Y2.Text;
                        break;
                    case 39:
                        Poz39.Text = Y2.Text;
                        break;
                    case 0:
                        B_Kraj_0_.Text = Y2.Text;
                        pozicijaY2 = 0;
                        break;


                }
            }
            else if (naRedu == 3 && pozicijaG2 >= 0)
            {
                switch (pozicijaG2P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = " .";
                        break;
                    case 12:
                        Poz12.Text = " .";
                        break;
                    case 13:
                        Poz13.Text = " .";
                        break;
                    case 14:
                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 0:
                        B_Kraj_0_.Text = " .";
                        break;


                }
                switch (pozicijaG2)
                {
                    case 1:
                        B_Izlaz_1_.Text = G2.Text;
                        break;
                    case 2:
                        Poz2.Text = G2.Text;
                        break;
                    case 3:
                        Poz3.Text = G2.Text;
                        break;
                    case 4:
                        Poz4.Text = G2.Text;
                        break;
                    case 5:
                        Poz5.Text = G2.Text;
                        break;
                    case 6:
                        Poz6.Text = G2.Text;
                        break;
                    case 7:
                        Poz7.Text = G2.Text;
                        break;
                    case 8:
                        Poz8.Text = G2.Text;
                        break;
                    case 9:
                        Poz9.Text = G2.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = G2.Text;
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = G2.Text;
                        break;
                    case 12:
                        Poz12.Text = G2.Text;
                        break;
                    case 13:
                        Poz13.Text = G2.Text;
                        break;
                    case 14:
                        Poz14.Text = G2.Text;
                        break;
                    case 15:
                        Poz15.Text = G2.Text;
                        break;
                    case 16:
                        Poz16.Text = G2.Text;
                        break;
                    case 17:
                        Poz17.Text = G2.Text;
                        break;
                    case 18:
                        Poz18.Text = G2.Text;
                        break;
                    case 19:
                        Poz19.Text = G2.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = G2.Text;
                        break;
                    case 21:
                        if (prviG2_Izaso == 0)
                            G_Izlaz_21_.Text = G2.Text;
                        else
                            GUlaz1.Text = G2.Text;
                        break;
                    case 22:
                        if (prviG2_Izaso == 0)
                            Poz22.Text = G2.Text;
                        else
                            GUlaz2.Text = G2.Text;

                        break;
                    case 23:
                        if (prviG2_Izaso == 0)
                            Poz23.Text = G2.Text;
                        else
                            GUlaz3.Text = G2.Text;

                        break;
                    case 24:
                        if (prviG2_Izaso == 0)
                            Poz24.Text = G2.Text;
                        else
                            GUlaz4.Text = G2.Text;

                        break;
                    case 25:
                        Poz25.Text = G2.Text;
                        break;
                    case 26:
                        Poz26.Text = G2.Text;
                        break;
                    case 27:
                        Poz27.Text = G2.Text;
                        break;
                    case 28:
                        Poz28.Text = G2.Text;
                        break;
                    case 29:
                        Poz29.Text = G2.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = G2.Text;
                        break;
                    case 31:
                        R_Izlaz_31_.Text = G2.Text;
                        break;
                    case 32:
                        Poz32.Text = G2.Text;
                        break;
                    case 33:
                        Poz33.Text = G2.Text;
                        break;
                    case 34:
                        Poz34.Text = G2.Text;
                        break;
                    case 35:
                        Poz35.Text = G2.Text;
                        break;
                    case 36:
                        Poz36.Text = G2.Text;
                        break;
                    case 37:
                        Poz37.Text = G2.Text;
                        break;
                    case 38:
                        Poz38.Text = G2.Text;
                        break;
                    case 39:
                        Poz39.Text = G2.Text;
                        break;
                    case 0:
                        B_Kraj_0_.Text = G2.Text;
                        pozicijaG2 = 0;
                        break;


                }
            }
            else if (naRedu == 4 && pozicijaR2 >= 0)
            {
                switch (pozicijaR2P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = " .";
                        break;
                    case 12:
                        Poz12.Text = " .";
                        break;
                    case 13:
                        Poz13.Text = " .";
                        break;
                    case 14:
                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 0:
                        B_Kraj_0_.Text = " .";
                        break;


                }
                switch (pozicijaR2)
                {
                    case 1:
                        B_Izlaz_1_.Text = R2.Text;
                        break;
                    case 2:
                        Poz2.Text = R2.Text;
                        break;
                    case 3:
                        Poz3.Text = R2.Text;
                        break;
                    case 4:
                        Poz4.Text = R2.Text;
                        break;
                    case 5:
                        Poz5.Text = R2.Text;
                        break;
                    case 6:
                        Poz6.Text = R2.Text;
                        break;
                    case 7:
                        Poz7.Text = R2.Text;
                        break;
                    case 8:
                        Poz8.Text = R2.Text;
                        break;
                    case 9:
                        Poz9.Text = R2.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = R2.Text;
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = R2.Text;
                        break;
                    case 12:
                        Poz12.Text = R2.Text;
                        break;
                    case 13:
                        Poz13.Text = R2.Text;
                        break;
                    case 14:
                        Poz14.Text = R2.Text;
                        break;
                    case 15:
                        Poz15.Text = R2.Text;
                        break;
                    case 16:
                        Poz16.Text = R2.Text;
                        break;
                    case 17:
                        Poz17.Text = R2.Text;
                        break;
                    case 18:
                        Poz18.Text = R2.Text;
                        break;
                    case 19:
                        Poz19.Text = R2.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = R2.Text;
                        break;
                    case 21:
                        G_Izlaz_21_.Text = R2.Text;
                        break;
                    case 22:
                        Poz22.Text = R2.Text;
                        break;
                    case 23:
                        Poz23.Text = R2.Text;
                        break;
                    case 24:
                        Poz24.Text = R2.Text;
                        break;
                    case 25:
                        Poz25.Text = R2.Text;
                        break;
                    case 26:
                        Poz26.Text = R2.Text;
                        break;
                    case 27:
                        Poz27.Text = R2.Text;
                        break;
                    case 28:
                        Poz28.Text = R2.Text;
                        break;
                    case 29:
                        Poz29.Text = R2.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = R2.Text;
                        break;
                    case 31:
                        if (prviR2_Izaso == 0)
                            R_Izlaz_31_.Text = R2.Text;
                        else
                            RUlaz1.Text = R2.Text;
                        break;
                    case 32:
                        if (prviR2_Izaso == 0)
                            Poz32.Text = R2.Text;
                        else
                            RUlaz2.Text = R2.Text;

                        break;
                    case 33:
                        if (prviR2_Izaso == 0)
                            Poz33.Text = R2.Text;
                        else
                            RUlaz3.Text = R2.Text;

                        break;
                    case 34:
                        if (prviR2_Izaso == 0)
                            Poz34.Text = R2.Text;
                        else
                            RUlaz4.Text = R2.Text;

                        break;
                    case 35:
                        Poz35.Text = R2.Text;
                        break;
                    case 36:
                        Poz36.Text = R2.Text;
                        break;
                    case 37:
                        Poz37.Text = R2.Text;
                        break;
                    case 38:
                        Poz38.Text = R2.Text;
                        break;
                    case 39:
                        Poz39.Text = R2.Text;
                        break;
                    case 0:
                        B_Kraj_0_.Text = R2.Text;
                        pozicijaR1 = 0;
                        break;


                }
            }
            brBacanja++;
           
            if (BUlaz1.Text != "." && BUlaz2.Text != "." && BUlaz3.Text != "." && BUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je plavi igrač!!!";
            }
            else if (RUlaz1.Text != "." && RUlaz2.Text != "." && RUlaz3.Text != "." && RUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je crveni igrač!!!";
            }
            else if (YUlaz1.Text != "." && YUlaz2.Text != "." && YUlaz3.Text != "." && YUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je žuti igrač!!!";
            }
            else if (GUlaz1.Text != "." && GUlaz2.Text != "." && GUlaz3.Text != "." && GUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je zeleni igrač!!!";
            }
        }

        private void TextBlock_SelectionChanged_3(object sender, RoutedEventArgs e)
        {

        }























        // Treci Klosar




        private void BuB3_Click(object sender, RoutedEventArgs e)
        {
            dozvola = 0;
            pozicijaB3P = pozicijaB3;
            pozicijaG3P = pozicijaG3;
            pozicijaR3P = pozicijaR3;
            pozicijaY3P = pozicijaY3;
            if (naRedu == 1 && pozicijaB3 >= 0)
            {


                pozicijaB3 += d;
                if (pozicijaB3 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                    prviR1_Izaso = 0;
                }
                else if (pozicijaB3 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                    prviG1_Izaso = 0;
                }
                else if (pozicijaB3 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }

                else if (pozicijaB3 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaB3 == pozicijaG2)
                {
                    pozicijaG2 = -21;
                    prviG2_Izaso = 0;
                }
                else if (pozicijaB3 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }

                else if (pozicijaB3 == pozicijaR3)
                {
                    pozicijaR3 = -31;
                    prviR3_Izaso = 0;
                }
                else if (pozicijaB3 == pozicijaG3)
                {
                    pozicijaG3 = -21;
                    prviG3_Izaso = 0;
                }
                else if (pozicijaB3 == pozicijaY3)
                {
                    pozicijaY3 = -11;
                    prviY3_Izaso = 0;
                }

                else if (pozicijaB3 == pozicijaR4)
                {
                    pozicijaR4 = -31;
                    prviR4_Izaso = 0;
                }
                else if (pozicijaB3 == pozicijaG4)
                {
                    pozicijaG4 = -21;
                    prviG4_Izaso = 0;
                }
                else if (pozicijaB3 == pozicijaY4)
                {
                    pozicijaY4 = -11;
                    prviY4_Izaso = 0;
                }


                if (pozicijaB3 > 44)
                {
                    pozicijaB3 -= d;

                }

            }
            else if (naRedu == 2 && pozicijaY3 >= 0)
            {

                pozicijaY3 += d;
                if (pozicijaY3 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                    prviR1_Izaso = 0;
                }
                else if (pozicijaY3 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                    prviG1_Izaso = 0;
                }
                else if (pozicijaY3 == pozicijaB1)
                {
                    pozicijaB1 = -11;
                    prviB1_Izaso = 0;
                }

                else if (pozicijaY3 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaY3 == pozicijaG2)
                {
                    pozicijaG2 = -21;
                    prviG2_Izaso = 0;
                }
                else if (pozicijaY3 == pozicijaB2)
                {
                    pozicijaB2 = -11;
                    prviB2_Izaso = 0;
                }

                else if (pozicijaY3 == pozicijaR3)
                {
                    pozicijaR3 = -31;
                    prviR3_Izaso = 0;
                }
                else if (pozicijaY3 == pozicijaG3)
                {
                    pozicijaG3 = -21;
                    prviG3_Izaso = 0;
                }
                else if (pozicijaY3 == pozicijaB3)
                {
                    pozicijaB3 = -11;
                    prviB3_Izaso = 0;
                }

                else if (pozicijaY3 == pozicijaR4)
                {
                    pozicijaR4 = -31;
                    prviR4_Izaso = 0;
                }
                else if (pozicijaY3 == pozicijaG4)
                {
                    pozicijaG4 = -21;
                    prviG4_Izaso = 0;
                }
                else if (pozicijaY3 == pozicijaB4)
                {
                    pozicijaB4 = -11;
                    prviB4_Izaso = 0;
                }
                
                if (pozicijaY3 >= 40)
                {
                    pozicijaY3 -= 40;
                    prviY3_Izaso = 1;
                }
                if (prviY3_Izaso == 1 && pozicijaY3 > 14)
                {
                    pozicijaY3 -= d;
                }

            }
            else if (naRedu == 3 && pozicijaG3 >= 0)
            {

                pozicijaG3 += d;
                if (pozicijaG3 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                    prviR1_Izaso = 0;
                }
                else if (pozicijaG3 == pozicijaB1)
                {
                    pozicijaB1 = -21;
                    prviB1_Izaso = 0;
                }
                else if (pozicijaG3 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }

                else if (pozicijaG3 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaG3 == pozicijaB2)
                {
                    pozicijaB2 = -21;
                    prviB2_Izaso = 0;
                }
                else if (pozicijaG3 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }

                else if (pozicijaG3 == pozicijaR3)
                {
                    pozicijaR3 = -31;
                    prviR3_Izaso = 0;
                }
                else if (pozicijaG3 == pozicijaB3)
                {
                    pozicijaB3 = -21;
                    prviB3_Izaso = 0;
                }
                else if (pozicijaG3 == pozicijaY3)
                {
                    pozicijaY3 = -11;
                    prviY3_Izaso = 0;
                }

                else if (pozicijaG3 == pozicijaR4)
                {
                    pozicijaR4 = -31;
                    prviR4_Izaso = 0;
                }
                else if (pozicijaG3 == pozicijaB4)
                {
                    pozicijaB4 = -21;
                    prviB4_Izaso = 0;
                }
                else if (pozicijaG3 == pozicijaY4)
                {
                    pozicijaY4 = -11;
                    prviY4_Izaso = 0;
                }
                if (pozicijaG3 >= 40)
                {
                    pozicijaG3 -= 40;
                    prviG3_Izaso = 1;


                }
                if (prviG3_Izaso == 1 && pozicijaG3 > 24)
                {
                    pozicijaG3 -= d;
                }
            }
            else if (naRedu == 4 && pozicijaR3 >= 0)
            {
                pozicijaR3 += d;
                if (pozicijaR3 == pozicijaB1)
                {
                    pozicijaB1 = -31;
                    prviB1_Izaso = 0;
                }
                else if (pozicijaR3 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                    prviG1_Izaso = 0;
                }
                else if (pozicijaR3 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }

                else if (pozicijaR3 == pozicijaB2)
                {
                    pozicijaB2 = -31;
                    prviB2_Izaso = 0;
                }
                else if (pozicijaR3 == pozicijaG2)
                {
                    pozicijaG2 = -21;
                    prviG2_Izaso = 0;
                }
                else if (pozicijaR3 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }

                else if (pozicijaR3 == pozicijaB3)
                {
                    pozicijaB3 = -31;
                    prviB3_Izaso = 0;
                }
                else if (pozicijaR3 == pozicijaG3)
                {
                    pozicijaG3 = -21;
                    prviG3_Izaso = 0;
                }
                else if (pozicijaR3 == pozicijaY3)
                {
                    pozicijaY3 = -11;
                    prviY3_Izaso = 0;
                }

                else if (pozicijaR3 == pozicijaB4)
                {
                    pozicijaB4 = -31;
                    prviB4_Izaso = 0;
                }
                else if (pozicijaR3 == pozicijaG4)
                {
                    pozicijaG4 = -21;
                    prviG4_Izaso = 0;
                }
                else if (pozicijaR3 == pozicijaY4)
                {
                    pozicijaY4 = -11;
                    prviY4_Izaso = 0;
                }
                if (pozicijaR3 >= 40)
                {
                    pozicijaR3 -= 40;
                    prviR3_Izaso = 1;

                }
                if (prviR3_Izaso == 1 && pozicijaR3 > 34)
                {
                    pozicijaR3 -= d;
                }
            }

            if (d == 6)
            {
                if (naRedu == 1)
                {

                    if (pozicijaB3 < 0)
                    {
                        B_Izlaz_1_.Text = B3.Text;
                        pozicijaB3 = Math.Abs(pozicijaB3);
                    }



                }
                else if (naRedu == 2)
                {

                    if (pozicijaY3 < 0)
                    {
                        Y_Izlaz_11_.Text = Y3.Text;
                        pozicijaY3 = Math.Abs(pozicijaY3);
                    }

                }
                else if (naRedu == 3)
                {

                    if (pozicijaG3 < 0)
                    {
                        G_Izlaz_21_.Text = G3.Text;
                        pozicijaG3 = Math.Abs(pozicijaG3);
                    }

                }
                else if (naRedu == 4)
                {

                    if (pozicijaR3 < 0)
                    {
                        R_Izlaz_31_.Text = R3.Text;
                        pozicijaR3 = Math.Abs(pozicijaR3);
                    }

                }
            }



            if (naRedu == 1 && pozicijaB3 >= 0)
            {
                switch (pozicijaB3P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = " .";
                        break;
                    case 12:
                        Poz12.Text = " .";
                        break;
                    case 13:
                        Poz13.Text = " .";
                        break;
                    case 14:
                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 40:
                        B_Kraj_0_.Text = " .";
                        break;
                    case 41:
                        BUlaz1.Text = " .";
                        break;
                    case 42:
                        BUlaz2.Text = " .";
                        break;
                    case 43:
                        BUlaz3.Text = " .";
                        break;
                    case 44:
                        BUlaz4.Text = " .";
                        break;


                }
                switch (pozicijaB3)
                {
                    case 1:
                        B_Izlaz_1_.Text = B3.Text;
                        break;
                    case 2:
                        Poz2.Text = B3.Text;
                        break;
                    case 3:
                        Poz3.Text = B3.Text;
                        break;
                    case 4:
                        Poz4.Text = B3.Text;
                        break;
                    case 5:
                        Poz5.Text = B3.Text;
                        break;
                    case 6:
                        Poz6.Text = B3.Text;
                        break;
                    case 7:
                        Poz7.Text = B3.Text;
                        break;
                    case 8:
                        Poz8.Text = B3.Text;
                        break;
                    case 9:
                        Poz9.Text = B3.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = B3.Text;
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = B3.Text;
                        break;
                    case 12:
                        Poz12.Text = B3.Text;
                        break;
                    case 13:
                        Poz13.Text = B3.Text;
                        break;
                    case 14:
                        Poz14.Text = B3.Text;
                        break;
                    case 15:
                        Poz15.Text = B3.Text;
                        break;
                    case 16:
                        Poz16.Text = B3.Text;
                        break;
                    case 17:
                        Poz17.Text = B3.Text;
                        break;
                    case 18:
                        Poz18.Text = B3.Text;
                        break;
                    case 19:
                        Poz19.Text = B3.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = B3.Text;
                        break;
                    case 21:
                        G_Izlaz_21_.Text = B3.Text;
                        break;
                    case 22:
                        Poz22.Text = B3.Text;
                        break;
                    case 23:
                        Poz23.Text = B3.Text;
                        break;
                    case 24:
                        Poz24.Text = B3.Text;
                        break;
                    case 25:
                        Poz25.Text = B3.Text;
                        break;
                    case 26:
                        Poz26.Text = B3.Text;
                        break;
                    case 27:
                        Poz27.Text = B3.Text;
                        break;
                    case 28:
                        Poz28.Text = B3.Text;
                        break;
                    case 29:
                        Poz29.Text = B3.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = B3.Text;
                        break;
                    case 31:
                        R_Izlaz_31_.Text = B3.Text;
                        break;
                    case 32:
                        Poz32.Text = B3.Text;
                        break;
                    case 33:
                        Poz33.Text = B3.Text;
                        break;
                    case 34:
                        Poz34.Text = B3.Text;
                        break;
                    case 35:
                        Poz35.Text = B3.Text;
                        break;
                    case 36:
                        Poz36.Text = B3.Text;
                        break;
                    case 37:
                        Poz37.Text = B3.Text;
                        break;
                    case 38:
                        Poz38.Text = B3.Text;
                        break;
                    case 39:
                        Poz39.Text = B3.Text;
                        break;
                    case 40:
                        B_Kraj_0_.Text = B3.Text;
                        pozicijaB3 = 0;
                        break;
                    case 41:
                        BUlaz1.Text = B3.Text;
                        break;
                    case 42:
                        BUlaz2.Text = B3.Text;
                        break;
                    case 43:
                        BUlaz3.Text = B3.Text;
                        break;
                    case 44:
                        BUlaz4.Text = B3.Text;
                        break;


                }
            }
            else if (naRedu == 2 && pozicijaY3 >= 0)
            {
                switch (pozicijaY3P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:

                        Y_Izlaz_11_.Text = " .";

                        break;
                    case 12:

                        Poz12.Text = " .";
                        break;
                    case 13:

                        Poz13.Text = " .";
                        break;
                    case 14:

                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 0:
                        B_Kraj_0_.Text = " .";
                        break;


                }
                switch (pozicijaY3)
                {
                    case 1:
                        B_Izlaz_1_.Text = Y3.Text;
                        break;
                    case 2:
                        Poz2.Text = Y3.Text;
                        break;
                    case 3:
                        Poz3.Text = Y3.Text;
                        break;
                    case 4:
                        Poz4.Text = Y3.Text;
                        break;
                    case 5:
                        Poz5.Text = Y3.Text;
                        break;
                    case 6:
                        Poz6.Text = Y3.Text;
                        break;
                    case 7:
                        Poz7.Text = Y3.Text;
                        break;
                    case 8:
                        Poz8.Text = Y3.Text;
                        break;
                    case 9:
                        Poz9.Text = Y3.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = Y3.Text;
                        break;
                    case 11:
                        if (prviY3_Izaso == 0)
                            Y_Izlaz_11_.Text = Y3.Text;
                        else
                            YUlaz1.Text = Y3.Text;

                        break;
                    case 12:
                        if (prviY3_Izaso == 0)
                            Poz12.Text = Y3.Text;
                        else
                            YUlaz2.Text = Y3.Text;

                        break;
                    case 13:
                        if (prviY3_Izaso == 0)
                            Poz13.Text = Y3.Text;
                        else
                            YUlaz3.Text = Y3.Text;

                        break;
                    case 14:
                        if (prviY3_Izaso == 0)
                            Poz14.Text = Y3.Text;
                        else
                            YUlaz4.Text = Y3.Text;

                        break;
                    case 15:
                        Poz15.Text = Y3.Text;
                        break;
                    case 16:
                        Poz16.Text = Y3.Text;
                        break;
                    case 17:
                        Poz17.Text = Y3.Text;
                        break;
                    case 18:
                        Poz18.Text = Y3.Text;
                        break;
                    case 19:
                        Poz19.Text = Y3.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = Y3.Text;
                        break;
                    case 21:
                        G_Izlaz_21_.Text = Y3.Text;
                        break;
                    case 22:
                        Poz22.Text = Y3.Text;
                        break;
                    case 23:
                        Poz23.Text = Y3.Text;
                        break;
                    case 24:
                        Poz24.Text = Y3.Text;
                        break;
                    case 25:
                        Poz25.Text = Y3.Text;
                        break;
                    case 26:
                        Poz26.Text = Y3.Text;
                        break;
                    case 27:
                        Poz27.Text = Y3.Text;
                        break;
                    case 28:
                        Poz28.Text = Y3.Text;
                        break;
                    case 29:
                        Poz29.Text = Y3.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = Y3.Text;
                        break;
                    case 31:
                        R_Izlaz_31_.Text = Y3.Text;
                        break;
                    case 32:
                        Poz32.Text = Y3.Text;
                        break;
                    case 33:
                        Poz33.Text = Y3.Text;
                        break;
                    case 34:
                        Poz34.Text = Y3.Text;
                        break;
                    case 35:
                        Poz35.Text = Y3.Text;
                        break;
                    case 36:
                        Poz36.Text = Y3.Text;
                        break;
                    case 37:
                        Poz37.Text = Y3.Text;
                        break;
                    case 38:
                        Poz38.Text = Y3.Text;
                        break;
                    case 39:
                        Poz39.Text = Y3.Text;
                        break;
                    case 0:
                        B_Kraj_0_.Text = Y3.Text;
                        pozicijaY3 = 0;
                        break;


                }
            }
            else if (naRedu == 3 && pozicijaG3 >= 0)
            {
                switch (pozicijaG3P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = " .";
                        break;
                    case 12:
                        Poz12.Text = " .";
                        break;
                    case 13:
                        Poz13.Text = " .";
                        break;
                    case 14:
                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 0:
                        B_Kraj_0_.Text = " .";
                        break;


                }
                switch (pozicijaG3)
                {
                    case 1:
                        B_Izlaz_1_.Text = G3.Text;
                        break;
                    case 2:
                        Poz2.Text = G3.Text;
                        break;
                    case 3:
                        Poz3.Text = G3.Text;
                        break;
                    case 4:
                        Poz4.Text = G3.Text;
                        break;
                    case 5:
                        Poz5.Text = G3.Text;
                        break;
                    case 6:
                        Poz6.Text = G3.Text;
                        break;
                    case 7:
                        Poz7.Text = G3.Text;
                        break;
                    case 8:
                        Poz8.Text = G3.Text;
                        break;
                    case 9:
                        Poz9.Text = G3.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = G3.Text;
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = G3.Text;
                        break;
                    case 12:
                        Poz12.Text = G3.Text;
                        break;
                    case 13:
                        Poz13.Text = G3.Text;
                        break;
                    case 14:
                        Poz14.Text = G3.Text;
                        break;
                    case 15:
                        Poz15.Text = G3.Text;
                        break;
                    case 16:
                        Poz16.Text = G3.Text;
                        break;
                    case 17:
                        Poz17.Text = G3.Text;
                        break;
                    case 18:
                        Poz18.Text = G3.Text;
                        break;
                    case 19:
                        Poz19.Text = G3.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = G3.Text;
                        break;
                    case 21:
                        if (prviG3_Izaso == 0)
                            G_Izlaz_21_.Text = G3.Text;
                        else
                            GUlaz1.Text = G3.Text;
                        break;
                    case 22:
                        if (prviG3_Izaso == 0)
                            Poz22.Text = G3.Text;
                        else
                            GUlaz2.Text = G3.Text;

                        break;
                    case 23:
                        if (prviG3_Izaso == 0)
                            Poz23.Text = G3.Text;
                        else
                            GUlaz3.Text = G3.Text;

                        break;
                    case 24:
                        if (prviG3_Izaso == 0)
                            Poz24.Text = G3.Text;
                        else
                            GUlaz4.Text = G3.Text;

                        break;
                    case 25:
                        Poz25.Text = G3.Text;
                        break;
                    case 26:
                        Poz26.Text = G3.Text;
                        break;
                    case 27:
                        Poz27.Text = G3.Text;
                        break;
                    case 28:
                        Poz28.Text = G3.Text;
                        break;
                    case 29:
                        Poz29.Text = G3.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = G3.Text;
                        break;
                    case 31:
                        R_Izlaz_31_.Text = G3.Text;
                        break;
                    case 32:
                        Poz32.Text = G3.Text;
                        break;
                    case 33:
                        Poz33.Text = G3.Text;
                        break;
                    case 34:
                        Poz34.Text = G3.Text;
                        break;
                    case 35:
                        Poz35.Text = G3.Text;
                        break;
                    case 36:
                        Poz36.Text = G3.Text;
                        break;
                    case 37:
                        Poz37.Text = G3.Text;
                        break;
                    case 38:
                        Poz38.Text = G3.Text;
                        break;
                    case 39:
                        Poz39.Text = G3.Text;
                        break;
                    case 0:
                        B_Kraj_0_.Text = G3.Text;
                        pozicijaG3 = 0;
                        break;


                }
            }
            else if (naRedu == 4 && pozicijaR3 >= 0)
            {
                switch (pozicijaR3P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = " .";
                        break;
                    case 12:
                        Poz12.Text = " .";
                        break;
                    case 13:
                        Poz13.Text = " .";
                        break;
                    case 14:
                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 0:
                        B_Kraj_0_.Text = " .";
                        break;


                }
                switch (pozicijaR3)
                {
                    case 1:
                        B_Izlaz_1_.Text = R3.Text;
                        break;
                    case 2:
                        Poz2.Text = R3.Text;
                        break;
                    case 3:
                        Poz3.Text = R3.Text;
                        break;
                    case 4:
                        Poz4.Text = R3.Text;
                        break;
                    case 5:
                        Poz5.Text = R3.Text;
                        break;
                    case 6:
                        Poz6.Text = R3.Text;
                        break;
                    case 7:
                        Poz7.Text = R3.Text;
                        break;
                    case 8:
                        Poz8.Text = R3.Text;
                        break;
                    case 9:
                        Poz9.Text = R3.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = R3.Text;
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = R3.Text;
                        break;
                    case 12:
                        Poz12.Text = R3.Text;
                        break;
                    case 13:
                        Poz13.Text = R3.Text;
                        break;
                    case 14:
                        Poz14.Text = R3.Text;
                        break;
                    case 15:
                        Poz15.Text = R3.Text;
                        break;
                    case 16:
                        Poz16.Text = R3.Text;
                        break;
                    case 17:
                        Poz17.Text = R3.Text;
                        break;
                    case 18:
                        Poz18.Text = R3.Text;
                        break;
                    case 19:
                        Poz19.Text = R3.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = R3.Text;
                        break;
                    case 21:
                        G_Izlaz_21_.Text = R3.Text;
                        break;
                    case 22:
                        Poz22.Text = R3.Text;
                        break;
                    case 23:
                        Poz23.Text = R3.Text;
                        break;
                    case 24:
                        Poz24.Text = R3.Text;
                        break;
                    case 25:
                        Poz25.Text = R3.Text;
                        break;
                    case 26:
                        Poz26.Text = R3.Text;
                        break;
                    case 27:
                        Poz27.Text = R3.Text;
                        break;
                    case 28:
                        Poz28.Text = R3.Text;
                        break;
                    case 29:
                        Poz29.Text = R3.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = R3.Text;
                        break;
                    case 31:
                        if (prviR3_Izaso == 0)
                            R_Izlaz_31_.Text = R3.Text;
                        else
                            RUlaz1.Text = R3.Text;
                        break;
                    case 32:
                        if (prviR3_Izaso == 0)
                            Poz32.Text = R3.Text;
                        else
                            RUlaz2.Text = R3.Text;

                        break;
                    case 33:
                        if (prviR3_Izaso == 0)
                            Poz33.Text = R3.Text;
                        else
                            RUlaz3.Text = R3.Text;

                        break;
                    case 34:
                        if (prviR3_Izaso == 0)
                            Poz34.Text = R3.Text;
                        else
                            RUlaz4.Text = R3.Text;

                        break;
                    case 35:
                        Poz35.Text = R3.Text;
                        break;
                    case 36:
                        Poz36.Text = R3.Text;
                        break;
                    case 37:
                        Poz37.Text = R3.Text;
                        break;
                    case 38:
                        Poz38.Text = R3.Text;
                        break;
                    case 39:
                        Poz39.Text = R3.Text;
                        break;
                    case 0:
                        B_Kraj_0_.Text = R3.Text;
                        pozicijaR3 = 0;
                        break;


                }
            }
            brBacanja++;
            
            if (brBacanja == 1)
            {
                naRedu++;
                brBacanja = 0;
            }

            if (naRedu == 5)
            {
                naRedu = 1;
            }
           
            if (BUlaz1.Text != "." && BUlaz2.Text != "." && BUlaz3.Text != "." && BUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je plavi igrač!!!";
            }
            else if (RUlaz1.Text != "." && RUlaz2.Text != "." && RUlaz3.Text != "." && RUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je crveni igrač!!!";
            }
            else if (YUlaz1.Text != "." && YUlaz2.Text != "." && YUlaz3.Text != "." && YUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je žuti igrač!!!";
            }
            else if (GUlaz1.Text != "." && GUlaz2.Text != "." && GUlaz3.Text != "." && GUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je zeleni igrač!!!";
            }
        }




       
        //  Četvrti klošari
       
        private void BuB4_Click(object sender, RoutedEventArgs e)
        {
            dozvola = 0;
            pozicijaB4P = pozicijaB4;
            pozicijaG4P = pozicijaG4;
            pozicijaR4P = pozicijaR4;
            pozicijaY4P = pozicijaY4;
            if (naRedu == 1 && pozicijaB4 >= 0)
            {


                pozicijaB4 += d;
                if (pozicijaB4 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                    prviR1_Izaso = 0;
                }
                else if (pozicijaB4 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                    prviG1_Izaso = 0;
                }
                else if (pozicijaB4 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }

                else if (pozicijaB4 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaB4 == pozicijaG2)
                {
                    pozicijaG2 = -21;
                    prviG2_Izaso = 0;
                }
                else if (pozicijaB4 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }

                else if (pozicijaB4 == pozicijaR3)
                {
                    pozicijaR3 = -31;
                    prviR3_Izaso = 0;
                }
                else if (pozicijaB4 == pozicijaG3)
                {
                    pozicijaG3 = -21;
                    prviG3_Izaso = 0;
                }
                else if (pozicijaB4 == pozicijaY3)
                {
                    pozicijaY3 = -11;
                    prviY3_Izaso = 0;
                }

                else if (pozicijaB4 == pozicijaR4)
                {
                    pozicijaR4 = -31;
                    prviR4_Izaso = 0;
                }
                else if (pozicijaB4 == pozicijaG4)
                {
                    pozicijaG4 = -21;
                    prviG4_Izaso = 0;
                }
                else if (pozicijaB4 == pozicijaY4)
                {
                    pozicijaY4 = -11;
                    prviY4_Izaso = 0;
                }

                if (pozicijaB4 > 44)
                {
                    pozicijaB4 -= d;

                }

            }
            else if (naRedu == 2 && pozicijaY4 >= 0)
            {

                pozicijaY4 += d;
                if (pozicijaY4 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                    prviR1_Izaso = 0;
                }
                else if (pozicijaY4 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                    prviG1_Izaso = 0;
                }
                else if (pozicijaY4 == pozicijaB1)
                {
                    pozicijaB1 = -11;
                    prviB1_Izaso = 0;
                }

                else if (pozicijaY4 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaY4 == pozicijaG2)
                {
                    pozicijaG2 = -21;
                    prviG2_Izaso = 0;
                }
                else if (pozicijaY4 == pozicijaB2)
                {
                    pozicijaB2 = -11;
                    prviB2_Izaso = 0;
                }

                else if (pozicijaY4 == pozicijaR3)
                {
                    pozicijaR3 = -31;
                    prviR3_Izaso = 0;
                }
                else if (pozicijaY4 == pozicijaG3)
                {
                    pozicijaG3 = -21;
                    prviG3_Izaso = 0;
                }
                else if (pozicijaY4 == pozicijaB3)
                {
                    pozicijaB3 = -11;
                    prviB3_Izaso = 0;
                }

                else if (pozicijaY4 == pozicijaR4)
                {
                    pozicijaR4 = -31;
                    prviR4_Izaso = 0;
                }
                else if (pozicijaY4 == pozicijaG4)
                {
                    pozicijaG4 = -21;
                    prviG4_Izaso = 0;
                }
                else if (pozicijaY4 == pozicijaB4)
                {
                    pozicijaB4 = -11;
                    prviB4_Izaso = 0;
                }
               
                if (pozicijaY4 >= 40)
                {
                    pozicijaY4 -= 40;
                    prviY4_Izaso = 1;
                }
                if (prviY4_Izaso == 1 && pozicijaY4 > 14)
                {
                    pozicijaY4 -= d;
                }

            }
            else if (naRedu == 3 && pozicijaG4 >= 0)
            {

                pozicijaG4 += d;
                if (pozicijaG4 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                    prviR1_Izaso = 0;
                }
                else if (pozicijaG4 == pozicijaB1)
                {
                    pozicijaB1 = -21;
                    prviB1_Izaso = 0;
                }
                else if (pozicijaG4 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }

                else if (pozicijaG4 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaG4 == pozicijaB2)
                {
                    pozicijaB2 = -21;
                    prviB2_Izaso = 0;
                }
                else if (pozicijaG4 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }

                else if (pozicijaG4 == pozicijaR3)
                {
                    pozicijaR3 = -31;
                    prviR3_Izaso = 0;
                }
                else if (pozicijaG4 == pozicijaB3)
                {
                    pozicijaB3 = -21;
                    prviB3_Izaso = 0;
                }
                else if (pozicijaG4 == pozicijaY3)
                {
                    pozicijaY3 = -11;
                    prviY3_Izaso = 0;
                }

                else if (pozicijaG4 == pozicijaR4)
                {
                    pozicijaR4 = -31;
                    prviR4_Izaso = 0;
                }
                else if (pozicijaG4 == pozicijaB4)
                {
                    pozicijaB4 = -21;
                    prviB4_Izaso = 0;
                }
                else if (pozicijaG4 == pozicijaY4)
                {
                    pozicijaY4 = -11;
                    prviY4_Izaso = 0;
                }
                if (pozicijaG4 >= 40)
                {
                    pozicijaG4 -= 40;
                    prviG4_Izaso = 1;


                }
                if (prviG4_Izaso == 1 && pozicijaG4 > 24)
                {
                    pozicijaG4 -= d;
                }
            }
            else if (naRedu == 4 && pozicijaR4 >= 0)
            {
                pozicijaR4 += d;
                if (pozicijaR4 == pozicijaB1)
                {
                    pozicijaB1 = -31;
                    prviB1_Izaso = 0;
                }
                else if (pozicijaR4 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                    prviG1_Izaso = 0;
                }
                else if (pozicijaR4 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }

                else if (pozicijaR4 == pozicijaB2)
                {
                    pozicijaB2 = -31;
                    prviB2_Izaso = 0;
                }
                else if (pozicijaR4 == pozicijaG2)
                {
                    pozicijaG2 = -21;
                    prviG2_Izaso = 0;
                }
                else if (pozicijaR4 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }

                else if (pozicijaR4 == pozicijaB3)
                {
                    pozicijaB3 = -31;
                    prviB3_Izaso = 0;
                }
                else if (pozicijaR4 == pozicijaG3)
                {
                    pozicijaG3 = -21;
                    prviG3_Izaso = 0;
                }
                else if (pozicijaR4 == pozicijaY3)
                {
                    pozicijaY3 = -11;
                    prviY3_Izaso = 0;
                }

                else if (pozicijaR4 == pozicijaB4)
                {
                    pozicijaB4 = -31;
                    prviB4_Izaso = 0;
                }
                else if (pozicijaR4 == pozicijaG4)
                {
                    pozicijaG4 = -21;
                    prviG4_Izaso = 0;
                }
                else if (pozicijaR4 == pozicijaY4)
                {
                    pozicijaY4 = -11;
                    prviY4_Izaso = 0;
                }
                if (pozicijaR4 >= 40)
                {
                    pozicijaR4 -= 40;
                    prviR4_Izaso = 1;

                }
                if (prviR4_Izaso == 1 && pozicijaR4 > 34)
                {
                    pozicijaR4 -= d;
                }
            }

            if (d == 6)
            {
                if (naRedu == 1)
                {

                    if (pozicijaB4 < 0)
                    {
                        B_Izlaz_1_.Text = B4.Text;
                        pozicijaB4 = Math.Abs(pozicijaB4);
                    }



                }
                else if (naRedu == 2)
                {

                    if (pozicijaY4 < 0)
                    {
                        Y_Izlaz_11_.Text = Y4.Text;
                        pozicijaY4 = Math.Abs(pozicijaY4);
                    }

                }
                else if (naRedu == 3)
                {

                    if (pozicijaG4 < 0)
                    {
                        G_Izlaz_21_.Text = G4.Text;
                        pozicijaG4 = Math.Abs(pozicijaG4);
                    }

                }
                else if (naRedu == 4)
                {

                    if (pozicijaR4 < 0)
                    {
                        R_Izlaz_31_.Text = R4.Text;
                        pozicijaR4 = Math.Abs(pozicijaR4);
                    }

                }
            }



            if (naRedu == 1 && pozicijaB4 >= 0)
            {
                switch (pozicijaB4P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = " .";
                        break;
                    case 12:
                        Poz12.Text = " .";
                        break;
                    case 13:
                        Poz13.Text = " .";
                        break;
                    case 14:
                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 40:
                        B_Kraj_0_.Text = " .";
                        break;
                    case 41:
                        BUlaz1.Text = " .";
                        break;
                    case 42:
                        BUlaz2.Text = " .";
                        break;
                    case 43:
                        BUlaz3.Text = " .";
                        break;
                    case 44:
                        BUlaz4.Text = " .";
                        break;


                }
                switch (pozicijaB4)
                {
                    case 1:
                        B_Izlaz_1_.Text = B4.Text;
                        break;
                    case 2:
                        Poz2.Text = B4.Text;
                        break;
                    case 3:
                        Poz3.Text = B4.Text;
                        break;
                    case 4:
                        Poz4.Text = B4.Text;
                        break;
                    case 5:
                        Poz5.Text = B4.Text;
                        break;
                    case 6:
                        Poz6.Text = B4.Text;
                        break;
                    case 7:
                        Poz7.Text = B4.Text;
                        break;
                    case 8:
                        Poz8.Text = B4.Text;
                        break;
                    case 9:
                        Poz9.Text = B4.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = B4.Text;
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = B4.Text;
                        break;
                    case 12:
                        Poz12.Text = B4.Text;
                        break;
                    case 13:
                        Poz13.Text = B4.Text;
                        break;
                    case 14:
                        Poz14.Text = B4.Text;
                        break;
                    case 15:
                        Poz15.Text = B4.Text;
                        break;
                    case 16:
                        Poz16.Text = B4.Text;
                        break;
                    case 17:
                        Poz17.Text = B4.Text;
                        break;
                    case 18:
                        Poz18.Text = B4.Text;
                        break;
                    case 19:
                        Poz19.Text = B4.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = B4.Text;
                        break;
                    case 21:
                        G_Izlaz_21_.Text = B4.Text;
                        break;
                    case 22:
                        Poz22.Text = B4.Text;
                        break;
                    case 23:
                        Poz23.Text = B4.Text;
                        break;
                    case 24:
                        Poz24.Text = B4.Text;
                        break;
                    case 25:
                        Poz25.Text = B4.Text;
                        break;
                    case 26:
                        Poz26.Text = B4.Text;
                        break;
                    case 27:
                        Poz27.Text = B4.Text;
                        break;
                    case 28:
                        Poz28.Text = B4.Text;
                        break;
                    case 29:
                        Poz29.Text = B4.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = B4.Text;
                        break;
                    case 31:
                        R_Izlaz_31_.Text = B4.Text;
                        break;
                    case 32:
                        Poz32.Text = B4.Text;
                        break;
                    case 33:
                        Poz33.Text = B4.Text;
                        break;
                    case 34:
                        Poz34.Text = B4.Text;
                        break;
                    case 35:
                        Poz35.Text = B4.Text;
                        break;
                    case 36:
                        Poz36.Text = B4.Text;
                        break;
                    case 37:
                        Poz37.Text = B4.Text;
                        break;
                    case 38:
                        Poz38.Text = B4.Text;
                        break;
                    case 39:
                        Poz39.Text = B4.Text;
                        break;
                    case 40:
                        B_Kraj_0_.Text = B4.Text;
                        pozicijaB4 = 0;
                        break;
                    case 41:
                        BUlaz1.Text = B4.Text;
                        break;
                    case 42:
                        BUlaz2.Text = B4.Text;
                        break;
                    case 43:
                        BUlaz3.Text = B4.Text;
                        break;
                    case 44:
                        BUlaz4.Text = B4.Text;
                        break;


                }
            }
            else if (naRedu == 2 && pozicijaY4 >= 0)
            {
                switch (pozicijaY4P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:

                        Y_Izlaz_11_.Text = " .";

                        break;
                    case 12:

                        Poz12.Text = " .";
                        break;
                    case 13:

                        Poz13.Text = " .";
                        break;
                    case 14:

                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 0:
                        B_Kraj_0_.Text = " .";
                        break;


                }
                switch (pozicijaY4)
                {
                    case 1:
                        B_Izlaz_1_.Text = Y4.Text;
                        break;
                    case 2:
                        Poz2.Text = Y4.Text;
                        break;
                    case 3:
                        Poz3.Text = Y4.Text;
                        break;
                    case 4:
                        Poz4.Text = Y4.Text;
                        break;
                    case 5:
                        Poz5.Text = Y4.Text;
                        break;
                    case 6:
                        Poz6.Text = Y4.Text;
                        break;
                    case 7:
                        Poz7.Text = Y4.Text;
                        break;
                    case 8:
                        Poz8.Text = Y4.Text;
                        break;
                    case 9:
                        Poz9.Text = Y4.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = Y4.Text;
                        break;
                    case 11:
                        if (prviY4_Izaso == 0)
                            Y_Izlaz_11_.Text = Y4.Text;
                        else
                            YUlaz1.Text = Y4.Text;

                        break;
                    case 12:
                        if (prviY4_Izaso == 0)
                            Poz12.Text = Y4.Text;
                        else
                            YUlaz2.Text = Y4.Text;

                        break;
                    case 13:
                        if (prviY4_Izaso == 0)
                            Poz13.Text = Y4.Text;
                        else
                            YUlaz3.Text = Y4.Text;

                        break;
                    case 14:
                        if (prviY4_Izaso == 0)
                            Poz14.Text = Y4.Text;
                        else
                            YUlaz4.Text = Y4.Text;

                        break;
                    case 15:
                        Poz15.Text = Y4.Text;
                        break;
                    case 16:
                        Poz16.Text = Y4.Text;
                        break;
                    case 17:
                        Poz17.Text = Y4.Text;
                        break;
                    case 18:
                        Poz18.Text = Y4.Text;
                        break;
                    case 19:
                        Poz19.Text = Y4.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = Y4.Text;
                        break;
                    case 21:
                        G_Izlaz_21_.Text = Y4.Text;
                        break;
                    case 22:
                        Poz22.Text = Y4.Text;
                        break;
                    case 23:
                        Poz23.Text = Y4.Text;
                        break;
                    case 24:
                        Poz24.Text = Y4.Text;
                        break;
                    case 25:
                        Poz25.Text = Y4.Text;
                        break;
                    case 26:
                        Poz26.Text = Y4.Text;
                        break;
                    case 27:
                        Poz27.Text = Y4.Text;
                        break;
                    case 28:
                        Poz28.Text = Y4.Text;
                        break;
                    case 29:
                        Poz29.Text = Y4.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = Y4.Text;
                        break;
                    case 31:
                        R_Izlaz_31_.Text = Y4.Text;
                        break;
                    case 32:
                        Poz32.Text = Y4.Text;
                        break;
                    case 33:
                        Poz33.Text = Y4.Text;
                        break;
                    case 34:
                        Poz34.Text = Y4.Text;
                        break;
                    case 35:
                        Poz35.Text = Y4.Text;
                        break;
                    case 36:
                        Poz36.Text = Y4.Text;
                        break;
                    case 37:
                        Poz37.Text = Y4.Text;
                        break;
                    case 38:
                        Poz38.Text = Y4.Text;
                        break;
                    case 39:
                        Poz39.Text = Y4.Text;
                        break;
                    case 0:
                        B_Kraj_0_.Text = Y4.Text;
                        pozicijaY4 = 0;
                        break;


                }
            }
            else if (naRedu == 3 && pozicijaG4 >= 0)
            {
                switch (pozicijaG4P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = " .";
                        break;
                    case 12:
                        Poz12.Text = " .";
                        break;
                    case 13:
                        Poz13.Text = " .";
                        break;
                    case 14:
                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 0:
                        B_Kraj_0_.Text = " .";
                        break;


                }
                switch (pozicijaG4)
                {
                    case 1:
                        B_Izlaz_1_.Text = G4.Text;
                        break;
                    case 2:
                        Poz2.Text = G4.Text;
                        break;
                    case 3:
                        Poz3.Text = G4.Text;
                        break;
                    case 4:
                        Poz4.Text = G4.Text;
                        break;
                    case 5:
                        Poz5.Text = G4.Text;
                        break;
                    case 6:
                        Poz6.Text = G4.Text;
                        break;
                    case 7:
                        Poz7.Text = G4.Text;
                        break;
                    case 8:
                        Poz8.Text = G4.Text;
                        break;
                    case 9:
                        Poz9.Text = G4.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = G4.Text;
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = G4.Text;
                        break;
                    case 12:
                        Poz12.Text = G4.Text;
                        break;
                    case 13:
                        Poz13.Text = G4.Text;
                        break;
                    case 14:
                        Poz14.Text = G4.Text;
                        break;
                    case 15:
                        Poz15.Text = G4.Text;
                        break;
                    case 16:
                        Poz16.Text = G4.Text;
                        break;
                    case 17:
                        Poz17.Text = G4.Text;
                        break;
                    case 18:
                        Poz18.Text = G4.Text;
                        break;
                    case 19:
                        Poz19.Text = G4.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = G4.Text;
                        break;
                    case 21:
                        if (prviG4_Izaso == 0)
                            G_Izlaz_21_.Text = G4.Text;
                        else
                            GUlaz1.Text = G4.Text;
                        break;
                    case 22:
                        if (prviG4_Izaso == 0)
                            Poz22.Text = G4.Text;
                        else
                            GUlaz2.Text = G4.Text;

                        break;
                    case 23:
                        if (prviG4_Izaso == 0)
                            Poz23.Text = G4.Text;
                        else
                            GUlaz3.Text = G4.Text;

                        break;
                    case 24:
                        if (prviG4_Izaso == 0)
                            Poz24.Text = G4.Text;
                        else
                            GUlaz4.Text = G4.Text;

                        break;
                    case 25:
                        Poz25.Text = G4.Text;
                        break;
                    case 26:
                        Poz26.Text = G4.Text;
                        break;
                    case 27:
                        Poz27.Text = G4.Text;
                        break;
                    case 28:
                        Poz28.Text = G4.Text;
                        break;
                    case 29:
                        Poz29.Text = G4.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = G4.Text;
                        break;
                    case 31:
                        R_Izlaz_31_.Text = G4.Text;
                        break;
                    case 32:
                        Poz32.Text = G4.Text;
                        break;
                    case 33:
                        Poz33.Text = G4.Text;
                        break;
                    case 34:
                        Poz34.Text = G4.Text;
                        break;
                    case 35:
                        Poz35.Text = G4.Text;
                        break;
                    case 36:
                        Poz36.Text = G4.Text;
                        break;
                    case 37:
                        Poz37.Text = G4.Text;
                        break;
                    case 38:
                        Poz38.Text = G4.Text;
                        break;
                    case 39:
                        Poz39.Text = G4.Text;
                        break;
                    case 0:
                        B_Kraj_0_.Text = G4.Text;
                        pozicijaG4 = 0;
                        break;


                }
            }
            else if (naRedu == 4 && pozicijaR4 >= 0)
            {
                switch (pozicijaR4P)
                {
                    case 1:
                        B_Izlaz_1_.Text = " .";
                        break;
                    case 2:
                        Poz2.Text = " .";
                        break;
                    case 3:
                        Poz3.Text = " .";
                        break;
                    case 4:
                        Poz4.Text = " .";
                        break;
                    case 5:
                        Poz5.Text = " .";
                        break;
                    case 6:
                        Poz6.Text = " .";
                        break;
                    case 7:
                        Poz7.Text = " .";
                        break;
                    case 8:
                        Poz8.Text = " .";
                        break;
                    case 9:
                        Poz9.Text = " .";
                        break;
                    case 10:
                        Y_Kraj_10_.Text = " .";
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = " .";
                        break;
                    case 12:
                        Poz12.Text = " .";
                        break;
                    case 13:
                        Poz13.Text = " .";
                        break;
                    case 14:
                        Poz14.Text = " .";
                        break;
                    case 15:
                        Poz15.Text = " .";
                        break;
                    case 16:
                        Poz16.Text = " .";
                        break;
                    case 17:
                        Poz17.Text = " .";
                        break;
                    case 18:
                        Poz18.Text = " .";
                        break;
                    case 19:
                        Poz19.Text = " .";
                        break;
                    case 20:
                        G_Kraj_20_.Text = " .";
                        break;
                    case 21:
                        G_Izlaz_21_.Text = " .";
                        break;
                    case 22:
                        Poz22.Text = " .";
                        break;
                    case 23:
                        Poz23.Text = " .";
                        break;
                    case 24:
                        Poz24.Text = " .";
                        break;
                    case 25:
                        Poz25.Text = " .";
                        break;
                    case 26:
                        Poz26.Text = " .";
                        break;
                    case 27:
                        Poz27.Text = " .";
                        break;
                    case 28:
                        Poz28.Text = " .";
                        break;
                    case 29:
                        Poz29.Text = " .";
                        break;
                    case 30:
                        R_Kraj_30_.Text = " .";
                        break;
                    case 31:
                        R_Izlaz_31_.Text = " .";
                        break;
                    case 32:
                        Poz32.Text = " .";
                        break;
                    case 33:
                        Poz33.Text = " .";
                        break;
                    case 34:
                        Poz34.Text = " .";
                        break;
                    case 35:
                        Poz35.Text = " .";
                        break;
                    case 36:
                        Poz36.Text = " .";
                        break;
                    case 37:
                        Poz37.Text = " .";
                        break;
                    case 38:
                        Poz38.Text = " .";
                        break;
                    case 39:
                        Poz39.Text = " .";
                        break;
                    case 0:
                        B_Kraj_0_.Text = " .";
                        break;


                }
                switch (pozicijaR4)
                {
                    case 1:
                        B_Izlaz_1_.Text = R4.Text;
                        break;
                    case 2:
                        Poz2.Text = R4.Text;
                        break;
                    case 3:
                        Poz3.Text = R4.Text;
                        break;
                    case 4:
                        Poz4.Text = R4.Text;
                        break;
                    case 5:
                        Poz5.Text = R4.Text;
                        break;
                    case 6:
                        Poz6.Text = R4.Text;
                        break;
                    case 7:
                        Poz7.Text = R4.Text;
                        break;
                    case 8:
                        Poz8.Text = R4.Text;
                        break;
                    case 9:
                        Poz9.Text = R4.Text;
                        break;
                    case 10:
                        Y_Kraj_10_.Text = R4.Text;
                        break;
                    case 11:
                        Y_Izlaz_11_.Text = R4.Text;
                        break;
                    case 12:
                        Poz12.Text = R4.Text;
                        break;
                    case 13:
                        Poz13.Text = R4.Text;
                        break;
                    case 14:
                        Poz14.Text = R4.Text;
                        break;
                    case 15:
                        Poz15.Text = R4.Text;
                        break;
                    case 16:
                        Poz16.Text = R4.Text;
                        break;
                    case 17:
                        Poz17.Text = R4.Text;
                        break;
                    case 18:
                        Poz18.Text = R4.Text;
                        break;
                    case 19:
                        Poz19.Text = R4.Text;
                        break;
                    case 20:
                        G_Kraj_20_.Text = R4.Text;
                        break;
                    case 21:
                        G_Izlaz_21_.Text = R4.Text;
                        break;
                    case 22:
                        Poz22.Text = R4.Text;
                        break;
                    case 23:
                        Poz23.Text = R4.Text;
                        break;
                    case 24:
                        Poz24.Text = R4.Text;
                        break;
                    case 25:
                        Poz25.Text = R4.Text;
                        break;
                    case 26:
                        Poz26.Text = R4.Text;
                        break;
                    case 27:
                        Poz27.Text = R4.Text;
                        break;
                    case 28:
                        Poz28.Text = R4.Text;
                        break;
                    case 29:
                        Poz29.Text = R4.Text;
                        break;
                    case 30:
                        R_Kraj_30_.Text = R4.Text;
                        break;
                    case 31:
                        if (prviR4_Izaso == 0)
                            R_Izlaz_31_.Text = R4.Text;
                        else
                            RUlaz1.Text = R4.Text;
                        break;
                    case 32:
                        if (prviR4_Izaso == 0)
                            Poz32.Text = R4.Text;
                        else
                            RUlaz2.Text = R4.Text;

                        break;
                    case 33:
                        if (prviR4_Izaso == 0)
                            Poz33.Text = R4.Text;
                        else
                            RUlaz3.Text = R4.Text;

                        break;
                    case 34:
                        if (prviR4_Izaso == 0)
                            Poz34.Text = R4.Text;
                        else
                            RUlaz4.Text = R4.Text;

                        break;
                    case 35:
                        Poz35.Text = R4.Text;
                        break;
                    case 36:
                        Poz36.Text = R4.Text;
                        break;
                    case 37:
                        Poz37.Text = R4.Text;
                        break;
                    case 38:
                        Poz38.Text = R4.Text;
                        break;
                    case 39:
                        Poz39.Text = R4.Text;
                        break;
                    case 0:
                        B_Kraj_0_.Text = R4.Text;
                        pozicijaR3 = 0;
                        break;


                }
            }
            brBacanja++;
            
            if (brBacanja == 1)
            {
                naRedu++;
                brBacanja = 0;
            }

            if (naRedu == 5)
            {
                naRedu = 1;
            }
           

            if (BUlaz1.Text != "." && BUlaz2.Text != "." && BUlaz3.Text != "." && BUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je plavi igrač!!!";
            }
            else if (RUlaz1.Text != "." && RUlaz2.Text != "." && RUlaz3.Text != "." && RUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je crveni igrač!!!";
            }
            else if (YUlaz1.Text != "." && YUlaz2.Text != "." && YUlaz3.Text != "." && YUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je žuti igrač!!!";
            }
            else if (GUlaz1.Text != "." && GUlaz2.Text != "." && GUlaz3.Text != "." && GUlaz4.Text != ".")
            {
                pobjeda.Text = "Pobijedio je zeleni igrač!!!";
            }
        }

        private void TextBlock_SelectionChanged_4(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_5(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_6(object sender, RoutedEventArgs e)
        {

        }
    }
}
