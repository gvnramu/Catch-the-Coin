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
    public sealed partial class PG_Level1 : Page
    {
        public PG_Level1()
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Story_Level1.Begin();
            Btn_GameStart.Content = "Play";
            Img_Coin.Visibility = Visibility.Collapsed;
            TxtBox_Failed.Visibility = Visibility.Collapsed;
           
        }

        private void Img_cup1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Img_Coin.Visibility = Visibility.Visible;
            Btn_NextLevel.Visibility = Visibility.Visible;
            TxtBox_Failed.Text = "Level Passed";
            TxtBox_Failed.Visibility = Visibility.Visible;

        }

        private void Img_cup2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Img_Coin.Visibility = Visibility.Visible;
            TxtBox_Failed.Text = "Level Failed";
            TxtBox_Failed.Visibility = Visibility.Visible;
            Btn_GameStart.Content = "Retry";

        }

        private void Img_cup3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Img_Coin.Visibility = Visibility.Visible;
            TxtBox_Failed.Text = "Level Failed";
            TxtBox_Failed.Visibility = Visibility.Visible;
            Btn_GameStart.Content = "Retry";
           
        }
        private void Btn_NextLevel_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PG_Level2));
        }
    }
}
