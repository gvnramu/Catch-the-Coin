using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Catch_the_Coin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PG_Level3 : Page
    {
        public PG_Level3()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Btn_GameStart_Click(object sender, RoutedEventArgs e)
        {
            Btn_GameStart.Content = "Play";
            Story_Level3.Begin();
            Img_Coin.Visibility = Visibility.Collapsed;

        }
        private void Img_cup1_Tapped(object sender, RoutedEventArgs e)
        {
            Btn_GameStart.Content = "Play";
            Img_Coin.Visibility = Visibility.Visible;
            Btn_NextLevel.Visibility = Visibility.Visible;
            TxtBox_LevelF_P.Text = "Level Passed";
            TxtBox_LevelF_P.Visibility = Visibility.Visible;
        }
        private void Img_cup2_Tapped(object sender, RoutedEventArgs e)
        {
            Btn_GameStart.Content = "Retry";
            Img_Coin.Visibility = Visibility.Visible;
            TxtBox_LevelF_P.Text = "Level Failed";
            TxtBox_LevelF_P.Visibility = Visibility.Visible;
        }
        private void Img_cup3_Tapped(object sender, RoutedEventArgs e)
        {
            Btn_GameStart.Content = "Retry";
            Img_Coin.Visibility = Visibility.Visible;
            TxtBox_LevelF_P.Text = "Level Failed";
            TxtBox_LevelF_P.Visibility = Visibility.Visible;
        }

        private void Btn_NextLevel_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
