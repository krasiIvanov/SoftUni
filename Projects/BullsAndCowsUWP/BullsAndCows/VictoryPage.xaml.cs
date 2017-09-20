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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BullsAndCows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VictoryPage : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;

        private string result;
        private int moves;
        private string targetNumber;

        public VictoryPage()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);

        }

        

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //this.moves = int.Parse(e.Parameter as string);
            var parametars = (EndGame)e.Parameter;
            this.moves = parametars.moves;
            this.result = parametars.resultType;
            this.targetNumber = parametars.targetNumber;

            SetMedal();
            SetText();
            
            
        }


        private void SetText()
        {
            if (result=="WIN")
            {
                textGreetnings.Text = $"You guess the number {targetNumber}";
            }
            else if (result=="LOSE")
            {
                lebel.Text = "YOU LOSE!!!";
                greetnings.Text = "Sorry!!!";
                textGreetnings.Text = $"You did not guess the number {targetNumber}";
            }
            else if (result=="SURR")
            {
                lebel.Text = "SURRENDER!!!";
                greetnings.Text = "Sorry!!!";
                textGreetnings.Text = $"You did not guess the number {targetNumber}";
            }
        }
        private void SetMedal()
        {
            var uri = new Uri("ms-appx://BullsAndCows/Assets/bronze.png");
            if (result=="WIN")
            {
                if (moves == 1)
                {
                    uri = new Uri("ms-appx://BullsAndCows/Assets/lucky.png");
                }
                else if (moves > 1 && moves <= 3)
                {
                    uri = new Uri("ms-appx://BullsAndCows/Assets/gold.png");
                }
                else if (moves > 3 && moves <= 6)
                {
                    uri = new Uri("ms-appx://BullsAndCows/Assets/silver.png");
                }
            }
            else if (result=="LOSE")
            {
                uri = new Uri("ms-appx://BullsAndCows/Assets/gameover.png");
            }
            else if (result=="SURR")
            {
                uri = new Uri("ms-appx://BullsAndCows/Assets/surrender.png");
            }
            
            MedalImage.Source = new BitmapImage(uri);
        }

        

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxNickName.Text.Length < 3 || txtBoxNickName.Text.Length > 8)
            {
                ShowDialog();
            }
            else
            {
                var insert = conn.Insert(new Game()
                {
                    Name = txtBoxNickName.Text.ToString(),
                    Move = moves,
                    Result = result
                });

                this.Frame.Navigate(typeof(MainPage));
            }
            
        }

        private void ShowDialog()
        {
            
                ContentDialog dialog = new ContentDialog()
                {
                    Title = "Wrong Nickname !!",
                    MaxWidth = this.ActualWidth,
                    PrimaryButtonText = "OK",
                    Content = new TextBlock
                    {
                        Text = "Nickname must be between 3 and 8 characters!",
                        FontSize = 20,
                        Foreground = new SolidColorBrush(Windows.UI.Colors.Blue),
                    },
                };

                dialog.ShowAsync();

               
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxNickName.Text.Length < 3 || txtBoxNickName.Text.Length > 8)
            {
                ShowDialog();
            }
            else
            {
                var insert = conn.Insert(new Game()
                {
                    Name = txtBoxNickName.Text.ToString(),
                    Move = moves,
                    Result = result
                });

                this.Frame.Navigate(typeof(GamePage));
            }
        }
    }
}
