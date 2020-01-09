using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
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
using T1809E_HelloUWP.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1809E_HelloUWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LogInPage : Page
    {
        private AuthenticationService _service = new AuthenticationService();
        public static string Token;
        public LogInPage()
        {
            this.InitializeComponent();
        }

        private async void Login_Clicked(object sender, RoutedEventArgs e)
        {
            var email = Email.Text;
            var password = Password.Password;

            Token = await this._service.LoginTask(email, password);
            this.Frame.Navigate(typeof(Pages.MemberInformation));
        }
        
        private void Reset_Clicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
