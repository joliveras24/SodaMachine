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

namespace SodaMachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {

            InitializeComponent();
            //bool first = true;



        }

        bool first = true;
        int press = 0;
        int numberPress = 0;
        int[] numberPress2 = new int[] { 0, 0 };




        string[] sodaMachine = new string[] { "coke", "tea", "coffe", "pepsi", "mountaindew", "redbull", "rockstar", "dietcoke",
                                             "coke1", "tea1", "coffe1", "pepsi1", "mountaindew1", "redbull1", "rockstar1", "dietcoke1",
                                             "coke2", "tea2", "coffe2", "wrong selection", "Try Again", "redbull2", "rockstar2", "dietcoke2",
                                             "coke4", "tea4", "coffe4", "pepsi4", "mountaindew4", "wrong selection", "Try Again", "dietcoke4",
                                             "coke3", "tea3", "coffe3", "pepsi3", "mountaindew3", "redbull3", "rocktar3", "Wrong Seclection",
                                             "Try Again","coke5", "tea5", "coffe5", "pepsi5", "mountaindew5", "redbull5", "rocktar5", "dietcoke5",
                                             "coke6", "tea6", "coffe6", "pepsi6", "mountaindew6", "redbull6", "rockstar6", "dietcoke6",
                                             "coke7", "tea7", "coffe7", "pepsi7", "mountaindew7", "redbull7", "rockstar7", "dietcoke7",
                                             "coke8", "tea8", "coffe8", "pepsi8", "mountaindew8", "redbull8", "rockstar8", "dietcoke8",
                                             "coke1", "tea1", "coffe1", "pepsi1", "mountaindew1", "redbull1", "rockstar1", "dietcoke1",
        "coke1", "tea1", "coffe1", "pepsi1", "mountaindew1", "redbull1", "rockstar1", "dietcoke1",
        "coke1", "tea1", "coffe1", "pepsi1", "mountaindew1", "redbull1", "rockstar1", "dietcoke1",
        "coke1", "tea1", "coffe1", "pepsi1", "mountaindew1", "redbull1", "rockstar1", "dietcoke1",};

        private void onClick(object sender, RoutedEventArgs e)
        {
            if (press == 1)
            {
                if ((!first))
                {
                    numberPress = numberPress2[0];
                    if (numberPress == 1) numberPress = 11;
                    if (numberPress == 2) numberPress = 21;
                    if (numberPress == 3) numberPress = 31;
                    if (numberPress == 4) numberPress = 41;
                    if (numberPress == 5) numberPress = 51;
                    MessageBox.Show(numberPress + " You got a " + sodaMachine[numberPress]);
                    press = 0;
                    first = true;
                }
                else
                {
                    MessageBox.Show(" Wrong Selection try again !!!");
                    first = true;
                    press = 0;
                }


            }

            else if (press == 0)
            {
                first = false;
                numberPress2[0] = 1;
                press = 1;
            }
        }

        private void onClick2(object sender, RoutedEventArgs e)
        {
            if (press == 1)
            {
                if (first == false)
                {
                    numberPress = numberPress2[0];
                    if (numberPress == 1) numberPress = 12;
                    if (numberPress == 2) numberPress = 22;
                    if (numberPress == 3) numberPress = 32;
                    if (numberPress == 4) numberPress = 42;
                    if (numberPress == 5) numberPress = 52;
                    MessageBox.Show(numberPress + " You have selected a " + sodaMachine[numberPress]);
                    press = 0;
                    first = true;
                }
                else  // it is the second number
                {
                    MessageBox.Show(" Wrong Selection try again !!!");
                    first = true;
                    press = 0;
                }

            }
            else if (press == 0)
            {
                first = false;
                numberPress2[0] = 2;
                press = 1;


            }


        }


        private void onClick3(object sender, RoutedEventArgs e)
        {
            if (press == 1)
            {
                
                if ((!first))
                {
                    numberPress = numberPress2[0];
                    if (numberPress == 1) numberPress = 13;
                    if (numberPress == 2) numberPress = 23;
                    if (numberPress == 3) numberPress = 33;
                    if (numberPress == 4) numberPress = 43;
                    if (numberPress == 5) numberPress = 53;
               

                   MessageBox.Show(numberPress + " You have selected a " + sodaMachine[numberPress]);
                    press = 0;
                    first = true;
                }
                else  // it is the second number
                {
                    MessageBox.Show(" Wrong Selection try again !!!");
                    first = true;
                    press = 0;
                }

            }
            else if (press == 0)
            {
                first = false;
                numberPress2[0] = 3;
                press = 1;
            }
        }





        private void onClick4(object sender, RoutedEventArgs e)
        {
            if (press == 1)
            {
                if ((!first))
                {
                    numberPress = numberPress2[0];
                    if (numberPress == 1) numberPress = 14;
                    if (numberPress == 2) numberPress = 24;
                    if (numberPress == 3) numberPress = 34;
                    if (numberPress == 4) numberPress = 44;
                    if (numberPress == 5) numberPress = 54;
                    MessageBox.Show(numberPress + " You have selected a " + sodaMachine[numberPress]);
                    press = 0;
                    first = true;
                }
                else  // it is the second number
                {
                    MessageBox.Show(" Wrong Selection try again !!!");
                    first = true;
                    press = 0;
                }

            }
            else if (press == 0)
            {
                first = false;
                numberPress2[0] = 4;
                press = 1;


            }
        }



        private void onClick5(object sender, RoutedEventArgs e)
        {
            if (press == 1)
            {
                if ((!first))
                {
                    numberPress = numberPress2[0];
                    if (numberPress == 1) numberPress = 15;
                    if (numberPress == 2) numberPress = 25;
                    if (numberPress == 3) numberPress = 35;
                    if (numberPress == 4) numberPress = 45;
                    if (numberPress == 5) numberPress = 55;

                    MessageBox.Show(numberPress + " You have selected a " + sodaMachine[numberPress]);
                    press = 0;
                    first = true;
                }
                else  // it is the second number
                {
                    MessageBox.Show(" Wrong Selection try again !!!");
                    first = true;
                    press = 0;
                }

            }
            else if (press == 0)
            {
                first = false;
                numberPress2[0] = 5;
                press = 1;

            }
        }



        private void onClick6(object sender, RoutedEventArgs e)
        {
            if (press == 1)
            {
                if ((!first))
                {
                    numberPress = numberPress2[0];
                    if (numberPress == 1) numberPress = 16;
                    if (numberPress == 2) numberPress = 26;
                    if (numberPress == 3) numberPress = 36;
                    if (numberPress == 4) numberPress = 46;
                    if (numberPress == 5) numberPress = 56;

                    MessageBox.Show(numberPress + " You have selected a " + sodaMachine[numberPress]);
                    press = 0;
                    first = true;
                }
                else  // it is the second number
                {
                    MessageBox.Show(" Wrong Selection try again !!!");
                    first = true;
                    press = 0;
                }

            }
            else if (press == 0)
            {
                MessageBox.Show(" *** You can only select numbers from 1-5 on the first digit *** ");
                MessageBox.Show(" Wrong Selection try again !!!");
                first = false;
                press = 0;

            }
            else
                press = 1;
        }



        private void onClick7(object sender, RoutedEventArgs e)
        {
            if (press == 1)
            {
                if ((!first))
                {
                    numberPress = numberPress2[0];
                    if (numberPress == 1) numberPress = 17;
                    if (numberPress == 2) numberPress = 27;
                    if (numberPress == 3) numberPress = 37;
                    if (numberPress == 4) numberPress = 47;
                    if (numberPress == 5) numberPress = 57;

                    MessageBox.Show(numberPress + " You have selected a " + sodaMachine[numberPress]);
                    press = 0;
                    first = true;
                }
                else  // it is the second number
                {
                    MessageBox.Show(" Wrong Selection try again !!!");
                    first = true;
                    press = 0;
                }

            }
            else if (press == 0)
            {
                MessageBox.Show(" *** You can only select numbers from 1-5 on the first digit *** ");
                MessageBox.Show(" Wrong Selection try again !!!");
                first = false;
                press = 0;

            }
            else
                press = 1;

        }

        private void onClick8(object sender, RoutedEventArgs e)
        {
            if (press == 1)
            {
                if ((!first))
                {
                    numberPress = numberPress2[0];
                    if (numberPress == 1) numberPress = 18;
                    if (numberPress == 2) numberPress = 28;
                    if (numberPress == 3) numberPress = 38;
                    if (numberPress == 4) numberPress = 48;
                    if (numberPress == 5) numberPress = 58;

                    MessageBox.Show(numberPress + " You have selected a " + sodaMachine[numberPress]);
                    press = 0;
                    first = true;
                }
                else  // it is the second number
                {
                    MessageBox.Show(" Wrong Selection try again !!!");
                    first = true;
                    press = 0;
                }

            }
            else if (press == 0)
            {
                MessageBox.Show(" *** You can only select numbers from 1-5 on the first digit *** ");
                MessageBox.Show(" Wrong Selection try again !!!");
                first = false;
                press = 0;

            }
            else
                press = 1;

        }




        private void onClick9(object sender, RoutedEventArgs e)
        {
            if (press == 1)
            {
                if ((!first))
                {
                   
                    MessageBox.Show(numberPress + " Selection Not Available ");
                    press = 0;
                }
                else  // it is the second number
                {
                    MessageBox.Show(" Wrong Selection try again !!!");
                    first = false;
                    press = 0;
                }

            }
            else if (press == 0)
            {
                MessageBox.Show(" *** You can only select numbers from 1-5 on the first digit *** ");
                MessageBox.Show(" Wrong Selection try again !!!");
                first = false;
                press = 0;

            }
            else
                press = 1;

        }



        private void onClick0(object sender, RoutedEventArgs e)
        {
            if (press == 1)
            {
                if ((!first))
                {

                    MessageBox.Show(numberPress + " Selection Not Available ");
                    press = 0;
                }
                else  // it is the second number
                {
                    MessageBox.Show(" Wrong Selection try again !!!");
                    first = false;
                    press = 0;
                }

            }
            else if (press == 0)
            {
                MessageBox.Show(" *** You can only select numbers from 1-5 on the first digit *** ");
                MessageBox.Show(" Wrong Selection try again !!!");
                first = false;
                press = 0;

            }
            else
                press = 1;

        }






        //  public int numberPress { get; set; }

        //  public string SodaMachine { get; set; }

        //  public string sodaMachine { get; set; }

        //  public int press { get; set; }
    }
}
