using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace إتبرع
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

        private void send1_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(57357, " ");
        }

        private async void ComposeSMS(int numb, string message)
        {
            var chatMessage = new Windows.ApplicationModel.Chat.ChatMessage();
            chatMessage.Body = message;
            var phone = numb;
            chatMessage.Recipients.Add(phone.ToString());
            await Windows.ApplicationModel.Chat.ChatMessageManager.ShowComposeSmsMessageAsync(chatMessage);
        }

        private void send2_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(9597, " ");
        }

        private void send3_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(9698, "قلب");
        }

        private void send4_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(9595, " ");
        }

        private void send5_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(9598, " ");
        }

        private void send6_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(95535, "n");
        }

        private void send7_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(95530, "ستر");
        }

        private void send8_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(9695, " ");
        }

        private void send9_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(9596, " ");
        }

        private void send10_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(95230, " ");
        }

        private void send11_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(9699, " ");
        }

        private void send12_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(95165, "معا");
        }

        private void send13_Click(object sender, RoutedEventArgs e)
        {
            ComposeSMS(9797, "6666");
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(info));
        }

        private async void add_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("#Comming_Soon :D");
            await dialog.ShowAsync();
        }

        private async void rate_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog RateDialog = new MessageDialog("Rate this app?");
            RateDialog.Commands.Add(new UICommand("Rate now", async (command) =>
            {
                await Launcher.LaunchUriAsync(
                new Uri($"ms-windows-store://review/?PFN={Package.Current.Id.FamilyName}"));
            }));
            RateDialog.Commands.Add(new UICommand("Not now"));
            RateDialog.DefaultCommandIndex = 0;
            RateDialog.CancelCommandIndex = 1;
            await RateDialog.ShowAsync();
        }
    }
}
