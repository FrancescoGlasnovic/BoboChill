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
        int pozicijaR2 = -1;
        int pozicijaG2 = -1;
        int pozicijaY2 = -11;
        //Treca
        int pozicijaB3P = -1;
        int pozicijaR3P = -31;
        int pozicijaG3P = -21;
        int pozicijaY3P = -11;
        int pozicijaB3 = -1;
        int pozicijaR3 = -1;
        int pozicijaG3 = -1;
        int pozicijaY3 = -11;
        //Cetvrta
        int pozicijaB4P = -1;
        int pozicijaR4P = -31;
        int pozicijaG4P = -21;
        int pozicijaY4P = -11;
        int pozicijaB4 = -1;
        int pozicijaR4 = -1;
        int pozicijaG4 = -1;
        int pozicijaY4 = -11;
        int dozvola = 1;
        int d;
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            Random rnd = new Random();
            
            d = rnd.Next(1, 7);
            Kocka.Text = Convert.ToString(d);
            
            if (dozvola == 1)
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
                    pozicijaB1 = -1;
                    prviB1_Izaso = 0;

                }
                if (pozicijaY1 >= 40)
                {
                    pozicijaY1 -= 40;
                    prviY1_Izaso = 1;
                }
                if (prviY1_Izaso == 1 && pozicijaY1 > 10)
                {
                    pozicijaB1 -= d;
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
                    pozicijaB1 = -1;
                    prviB1_Izaso = 0;
                }
                else if (pozicijaG1 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                    prviY1_Izaso = 0;
                }
                if (pozicijaG1 >= 40)
                {
                    pozicijaG1 -= 40;
                    prviG1_Izaso = 1;


                }
                if (prviG1_Izaso == 1 && pozicijaG1 > 20)
                {
                    pozicijaG1 -= d;
                }
            }
            else if (naRedu == 4 && pozicijaR1 >= 0)
            {
                pozicijaR1 += d;
                if (pozicijaR1 == pozicijaB1)
                {
                    pozicijaB1 = -1;
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
                if (pozicijaR1 >= 40)
                {
                    pozicijaR1 -= 40;
                    prviR1_Izaso = 1;

                }
                if (prviR1_Izaso == 1 && pozicijaR1 > 30)
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
                    case 40:
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
            BrBac.Text = Convert.ToString(brBacanja);
            
            R5.Text = Convert.ToString(pozicijaR1);
            B5.Text = Convert.ToString(pozicijaB1);
            G5.Text = Convert.ToString(pozicijaG1);
            Y5.Text = Convert.ToString(pozicijaY1);
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
                if (pozicijaB2 == pozicijaR2)
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


                if (pozicijaB2 > 44)
                {
                    pozicijaB2 -= d;

                }

            }
            else if (naRedu == 2 && pozicijaY2 >= 0)
            {

                pozicijaY2 += d;
                if (pozicijaY2 == pozicijaR2)
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
                    pozicijaB2 = -1;
                    prviB2_Izaso = 0;

                }
                if (pozicijaY2 >= 40)
                {
                    pozicijaY2 -= 40;
                    prviY2_Izaso = 1;
                }
                if (prviY2_Izaso == 1 && pozicijaY2 > 10)
                {
                    pozicijaB2 -= d;
                }

            }
            else if (naRedu == 3 && pozicijaG2 >= 0)
            {

                pozicijaG2 += d;
                if (pozicijaG2 == pozicijaR2)
                {
                    pozicijaR2 = -31;
                    prviR2_Izaso = 0;
                }
                else if (pozicijaG2 == pozicijaB2)
                {
                    pozicijaB2 = -1;
                    prviB2_Izaso = 0;
                }
                else if (pozicijaG2 == pozicijaY2)
                {
                    pozicijaY2 = -11;
                    prviY2_Izaso = 0;
                }
                if (pozicijaG2 >= 40)
                {
                    pozicijaG2 -= 40;
                    prviG2_Izaso = 1;


                }
                if (prviG2_Izaso == 1 && pozicijaG2 > 20)
                {
                    pozicijaG2 -= d;
                }
            }
            else if (naRedu == 4 && pozicijaR2 >= 0)
            {
                pozicijaR2 += d;
                if (pozicijaR2 == pozicijaB2)
                {
                    pozicijaB2 = -1;
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
                    prviY1_Izaso = 0;
                }
                if (pozicijaR2 >= 40)
                {
                    pozicijaR2 -= 40;
                    prviR2_Izaso = 1;

                }
                if (prviR2_Izaso == 1 && pozicijaR2 > 30)
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
                    case 40:
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
                    case 40:
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
                    case 40:
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
                    case 40:
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
                    case 40:
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
                    case 40:
                        B_Kraj_0_.Text = R2.Text;
                        pozicijaR1 = 0;
                        break;


                }
            }
            brBacanja++;
            BrBac.Text = Convert.ToString(brBacanja);
            
            R5.Text = Convert.ToString(pozicijaR1);
            B5.Text = Convert.ToString(pozicijaB1);
            G5.Text = Convert.ToString(pozicijaG1);
            Y5.Text = Convert.ToString(pozicijaY1);
        }

        private void TextBlock_SelectionChanged_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
