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
        int prviB1 = 0;
        int prviR1 = 0;
        int prviG1 = 0;
        int prviY1 = 0;
        int naRedu = 1;
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
        int pozicijaB2 = -1;
        int pozicijaR2 = -1;
        int pozicijaG2 = -1;
        int pozicijaY2 = -11;
        //Treca
        int pozicijaB3 = -1;
        int pozicijaR3 = -1;
        int pozicijaG3 = -1;
        int pozicijaY3 = -11;
        //Cetvrta
        int pozicijaB4 = -1;
        int pozicijaR4 = -1;
        int pozicijaG4 = -1;
        int pozicijaY4 = -11;
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            Random rnd = new Random();
            int d;
            d = rnd.Next(1, 7);
            Kocka.Text = Convert.ToString(d);
            pozicijaB1P = pozicijaB1;
            pozicijaG1P = pozicijaG1;
            pozicijaR1P = pozicijaR1;
            pozicijaY1P = pozicijaY1;
            if (naRedu == 1 && pozicijaB1 >= 0)
            {


                pozicijaB1 += d;
                if(pozicijaB1==pozicijaR1)
                {
                    pozicijaR1 = -31;
                }
                else if(pozicijaB1 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                }
                else if(pozicijaB1 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                }
            }
            else if (naRedu == 2 && pozicijaY1 >= 0)
            {

                pozicijaY1 += d;
                if (pozicijaY1 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                }
                else if (pozicijaY1 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                }
                else if (pozicijaY1 == pozicijaB1)
                {
                    pozicijaB1 = -1;
                }
            }
            else if (naRedu == 3 && pozicijaG1 >= 0)
            {

                pozicijaG1 += d;
                if (pozicijaG1 == pozicijaR1)
                {
                    pozicijaR1 = -31;
                }
                else if (pozicijaG1 == pozicijaB1)
                {
                    pozicijaB1 = -1;
                }
                else if (pozicijaG1 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                }
            }
            else if (naRedu == 4 && pozicijaR1 >= 0)
            {
                pozicijaR1 += d;
                if (pozicijaR1 == pozicijaB1)
                {
                    pozicijaB1 = -1;
                }
                else if (pozicijaR1 == pozicijaG1)
                {
                    pozicijaG1 = -21;
                }
                else if (pozicijaR1 == pozicijaY1)
                {
                    pozicijaY1 = -11;
                }
            }

            if (d == 6)
            {
                if (naRedu == 1)
                {
                    B_Izlaz_1_.Text = B1.Text;
                    if (pozicijaB1 < 0)
                    {
                        pozicijaB1 = Math.Abs(pozicijaB1);
                    }



                }
                else if (naRedu == 2)
                {
                    Y_Izlaz_11_.Text = Y1.Text;
                    if (pozicijaY1 < 0)
                    {
                        pozicijaY1 = Math.Abs(pozicijaY1);
                    }

                }
                else if (naRedu == 3)
                {
                    G_Izlaz_21_.Text = G1.Text;
                    if (pozicijaG1 < 0)
                    {
                        pozicijaG1 = Math.Abs(pozicijaG1);
                    }

                }
                else if (naRedu == 4)
                {
                    R_Izlaz_31_.Text = R1.Text;
                    if (pozicijaR1 < 0)
                    {
                        pozicijaR1 = Math.Abs(pozicijaR1);
                    }

                }
            }
            
              
            
            if(naRedu==1 && pozicijaB1>=0)
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
                        Y_Izlaz_11_.Text = Y1.Text;
                        break;
                    case 12:
                        Poz12.Text = Y1.Text;
                        break;
                    case 13:
                        Poz13.Text = Y1.Text;
                        break;
                    case 14:
                        Poz14.Text = Y1.Text;
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
                        G_Izlaz_21_.Text = G1.Text;
                        break;
                    case 22:
                        Poz22.Text = G1.Text;
                        break;
                    case 23:
                        Poz23.Text = G1.Text;
                        break;
                    case 24:
                        Poz24.Text = G1.Text;
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
                        R_Izlaz_31_.Text = R1.Text;
                        break;
                    case 32:
                        Poz32.Text = R1.Text;
                        break;
                    case 33:
                        Poz33.Text = R1.Text;
                        break;
                    case 34:
                        Poz34.Text = R1.Text;
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
                        break;


                }
            }
            brBacanja++;
            BrBac.Text = Convert.ToString(brBacanja);
                if(brBacanja==1)
                    {
                naRedu++;
                brBacanja = 0;
                    }
            
            if(naRedu==5)
            {
                naRedu = 1;
            }
            R5.Text = Convert.ToString(pozicijaR1);
            B5.Text = Convert.ToString(pozicijaB1);
            G5.Text = Convert.ToString(pozicijaG1);
            Y5.Text = Convert.ToString(pozicijaY1);
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

        private void TextBlock_SelectionChanged_polje(object sender, RoutedEventArgs e)
        {

        }
    }
}
