using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BullsAndCows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        

        static int[] numbers = new int[4];
        int moves = 0;
        string resultType;
        string targetNumber;

        public GamePage()
        {
            this.InitializeComponent();
            
            GenerateNumber();
            textBox.PlaceholderText = GetNumber();
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length != 4 || textBox.Text[0]=='0')
            {
                ContentDialog dialog = new ContentDialog()
                {
                    Title = "Wrong input !!",
                    MaxWidth = this.ActualWidth,
                    PrimaryButtonText = "OK",
                    Content = new TextBlock
                    {
                        Text = "The input must be 4 digits,\nand cannot start with 0!",
                        FontSize = 24,
                        Foreground = new SolidColorBrush(Windows.UI.Colors.Blue),
                    },
                };

                dialog.ShowAsync();
                
                
            }
            else
            {
                GetBullsAndCows();
            }

            textBox.Text = String.Empty;
            textBox.Focus(FocusState.Programmatic);


        }

        private void btnSurr_Click(object sender, RoutedEventArgs e)
        {
            //textBox.Text = GetNumber();
            targetNumber = GetNumber();
            resultType = "SURR";
            var game = new EndGame(moves, resultType, targetNumber);
            this.Frame.Navigate(typeof(VictoryPage), game);
        }

        

        private void textBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            
            IsDigit(e);
            IsUnique(e);
        }

        //check input is digit
        private void IsDigit(KeyRoutedEventArgs e)
        {
            if (Regex.IsMatch(((char)e.Key).ToString(), "[0-9]") && textBox.Text.ToString().Length < 4)
                e.Handled = false;
            else e.Handled = true;
        }

        //check is unique digit
        private void IsUnique(KeyRoutedEventArgs e)
        {
            
            int input;
            if (int.TryParse(((char)e.Key).ToString(), out input))
            {
                int[] previousInput = textBox.Text.ToCharArray().Select(d => Convert.ToInt32(d) - 48).ToArray();

                
                if (previousInput.Contains(input))
                {
                    e.Handled = true;
                }
            }
        }

        //generate 4-digit number
        private void GenerateNumber()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = GenerateRandomDigit();
            }
        }

        //generate random unique digit
        private int GenerateRandomDigit()
        {
            Random rand = new Random();
            int digit;
            do
            {
                digit = rand.Next(1, 9);

            } while (numbers.Contains(digit));

            return digit;
        }


        //find bulls and cows
        private void GetBullsAndCows()
        {
            string playerInput = textBox.Text;
            int[] playerDigits = playerInput.ToCharArray().Select(d => Convert.ToInt32(d) - 48).ToArray();

            int bulls = 0;
            int cows = 0;

            for (int i = 0; i < playerDigits.Length; i++)
            {
                if (numbers.Contains(playerDigits[i]))
                {
                    if (numbers[i]==playerDigits[i])
                    {
                        bulls++;
                    }
                    else
                    {
                        cows++;
                    }
                }
            }
            moves++;

            ShowResult(moves, playerInput, bulls, cows);
            
            if (bulls==4)
            {
                targetNumber = GetNumber();
                resultType = "WIN";
                var game = new EndGame(moves,resultType,targetNumber);
                this.Frame.Navigate(typeof(VictoryPage), game);

                
            }
            if (moves==10)
            {
                targetNumber = GetNumber();
                resultType = "LOSE";
                var game = new EndGame(moves, resultType,targetNumber);            
                this.Frame.Navigate(typeof(VictoryPage), game);
            }
        }


        //print result for guest in stack panel
        private void ShowResult(int moves,string playerInput,int bulls, int cows)
        {
            listWithGuess.Children.Add(new TextBlock
            {
                Text = $"{moves}) {playerInput} : {bulls.ToString()} BULLS AND {cows.ToString()} COWS",
                Foreground = new SolidColorBrush(Windows.UI.Colors.White),
                FontSize = 30


            });
        }

        //get the random number
        private string GetNumber()
        {
            string result="";
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i].ToString();
            }
            return result;
        }
    }
}
