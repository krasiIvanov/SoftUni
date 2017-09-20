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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BullsAndCows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ResultPage : Page
    {
        
        string path;
        SQLite.Net.SQLiteConnection conn;
        public ResultPage()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);

            var query = conn.Table<Game>();
            string name = "";
            string move = "";
            string result = "";
            foreach (var message in query)
            {

                name = message.Name;
                move = message.Move.ToString();
                result =message.Result;

                showResult(name, move, result);
            }

            

        }
        private void showResult(string name,string moves,string result)
        {
            listWithResult.Children.Add(new TextBlock
            {
                Text = result,
                Foreground = new SolidColorBrush(Windows.UI.Colors.White),
                FontSize = 25


            });
            listWithMoves.Children.Add(new TextBlock
            {
                Text = moves,
                Foreground = new SolidColorBrush(Windows.UI.Colors.White),
                FontSize = 25


            });
            listWithNames.Children.Add(new TextBlock
            {
                Text = name,
                Foreground = new SolidColorBrush(Windows.UI.Colors.White),
                FontSize = 25


            });
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }
    }
}
